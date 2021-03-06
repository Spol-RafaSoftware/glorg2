﻿/*
Copyright (C) 2010 Henning Moe

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Glorg2.Graphics.OpenGL;
namespace Glorg2.Resource
{
	public class HdrImporter : ResourceImporter
	{

		private static Regex reg = new Regex(@"(?<YSign>\+|\-)Y\s*(?<YValue>[0-9]+)\s(?<XSign>\+|\-)X\s*(?<XValue>[0-9]+)", RegexOptions.Compiled);
        internal static readonly Type[] supported_types = new Type[] { typeof(Texture), typeof(Texture2D) };
        public override IEnumerable<Type> SupportedTypes
        {
            get { return supported_types; }
        }

        public override string FileDescriptor
		{
			get { return "texture.hdr"; }
		}

        public override int Priority
        {
            get { return 50; }
        }

		public struct Rgbe
		{
			public byte red, green, blue, exp;

			public Rgbe(System.IO.Stream src)
			{
				byte[] vals = new byte[4];
				if (src.Read(vals, 0, 4) < 4)
					throw new EndOfStreamException("Unexpected end of stream");
				red = vals[0];
				green = vals[1];
				blue = vals[2];
				exp = vals[3];
			}

			public Vector3Half ToVector3Half()
			{
				Vector3Half ret = new Vector3Half();
				if (exp != 0)
				{
					float f = (float)Math.Pow(2.0, exp - (int)(128 + 8));
					ret.x = (Half)(red * f);
					ret.y = (Half)(green * f);
					ret.z = (Half)(blue * f);
				}
				return ret;
			}
		}

		private void ReadRgbe(System.IO.Stream src, Vector3Half[] ret)
		{
			for (int i = 0; i < ret.Length; i++)
			{
				var item = new Rgbe(src);
				ret[i] = item.ToVector3Half();
			}
		}
		/*
			Retrieved from the source code written by Greg Ward for reading Radiance HDR images.
		 */
		private void ReadRgbeRle(System.IO.Stream src, Vector3Half[] ret, int width, int height)
		{
			byte[] rgbe = new byte[4]; byte[] scanline_buffer; int ptr, ptr_end;
			int i, count, index = 0;
			byte[] buf = new byte[2];

			if ((width < 8) || (width > 0x7fff))
			{
				/* run length encoding is not allowed so read flat*/
				ReadRgbe(src, ret);
				return;
			}
			scanline_buffer = null;
			int num_scanlines = height;
			/* read in each successive scanline */
			long start = src.Position;
			while (num_scanlines > 0)
			{
				if (src.Read(rgbe, 0, 4) < 1)
					throw new FormatException();
				if ((rgbe[0] != 2) || (rgbe[1] != 2) || ((rgbe[2] & 0x80) == 0x80))
				{
					/* this file is not run length encoded */
					//rgbe2float(&data[0],&data[1],&data[2],rgbe);
					//data += RGBE_DATA_SIZE;
					//free(scanline_buffer);
					//return RGBE_ReadPixels(fp,data,scanline_width*num_scanlines-1);
					//src.Position = start;
					//ReadRgbe(src, ret);
					//return;
				}
				//if ((((int)rgbe[2]) << 8 | rgbe[3]) != width)
				//{
//					throw new FormatException();
				//}
				if (scanline_buffer == null)
					scanline_buffer = new byte[4 * width];

				ptr = 0;
				/* read each of the four channels for the scanline into the buffer */
				for (i = 0; i < 4; i++)
				{
					ptr_end = (i + 1) * width;
					while (ptr < ptr_end)
					{
						if (src.Read(buf, 0, 2) < 1)
						{
							throw new EndOfStreamException();
						}
						if (buf[0] > 128)
						{
							/* a run of the same value */
							count = buf[0] - 128;
							if ((count == 0) || (count > ptr_end - ptr))
							{
								throw new FormatException();
							}
							while (count-- > 0)
								scanline_buffer[ptr++] = buf[1];
						}
						else
						{
							/* a non-run */
							count = buf[0];
							if ((count == 0) || (count > ptr_end - ptr))
							{
								throw new FormatException();
							}
							scanline_buffer[ptr++] = buf[1];
							if (--count > 0)
							{
								if (src.Read(scanline_buffer, ptr, count) < 1)
								{
									throw new EndOfStreamException();
								}
								ptr += count;
							}
						}
					}
				}
				/* now convert data from buffer into floats */

				for (i = 0; i < width; i++)
				{
					Rgbe r = new Rgbe()
					{
						red = scanline_buffer[i],
						green = scanline_buffer[i + width],
						blue = scanline_buffer[i + 2 * width],
						exp = scanline_buffer[i + 3 * width]
					};
					ret[index] = r.ToVector3Half();
				}
				num_scanlines--;
			}
		}

		public override T Import<T>(System.IO.Stream source, string source_name, ResourceManager man)
		{
			Glorg2.Graphics.OpenGL.Texture2D res;
			var rd = new StreamReader(source, false);
			string line = rd.ReadLine();
			string format = "";
			int width = -1, height = -1;
			int exposure = 0;
			Match m;
			if (line != "#?RADIANCE")
				throw new FormatException("Unrecognized HDR format");
			while (true)
			{
				line = rd.ReadLine();
				int index = line.IndexOf('=');
				if (index > 0)
				{
					string name = line.Substring(0, index);
					string value = line.Substring(index + 1);
					if (name == "EXPOSURE")
						exposure = int.Parse(value);
					else if (name == "FORMAT")
						format = value;
				}
				else if ((m = reg.Match(line)).Success)
				{
					width = int.Parse(m.Groups["XValue"].Value);
					height = int.Parse(m.Groups["YValue"].Value);
					break;
				}
			}
			if (width == -1 || height == -1)
				throw new FormatException("Could not figure out the size of the HDR image");


			Vector3Half[] data = new Vector3Half[width * height];

			if (format == "32-bit_rgbe" || (width < 8 || width > 0x7FFFF))
				ReadRgbe(source, data);
			else if (format == "32-bit_rle_rgbe")
				ReadRgbeRle(source, data, width, height);
			else if (format == "32-bit_rle_xyzw")
				throw new NotSupportedException(format + " not supported.");

			res = new Graphics.OpenGL.Texture2D(width, height, Graphics.OpenGL.InternalFormat.Rgb16, Graphics.OpenGL.PixelDataType.Float, Graphics.OpenGL.PixelType.Rgb, source_name);
			res.AssignBuffer(data);
			return res as T;

		}


	}
}
