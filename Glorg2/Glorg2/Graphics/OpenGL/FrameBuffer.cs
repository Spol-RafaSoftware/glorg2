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

namespace Glorg2.Graphics.OpenGL
{
	public sealed class FrameBuffer : IDeviceObject
	{
		uint handle;
		int width, height;
		internal List<RenderBuffer> render_buffers;
		public uint Handle { get { return handle; } }

		public System.Collections.ObjectModel.ReadOnlyCollection<RenderBuffer> RenderBuffers { get { return render_buffers.AsReadOnly(); } }

		public int Width { get { return width; } }
		public int Height { get { return height; } }

		public FrameBuffer(int width, int height)
		{
			render_buffers = new List<RenderBuffer>();
			uint[] buffers = new uint[1];
			OpenGL.glGenFramebuffers(1, buffers);
			handle = buffers[0];
			this.width = width;
			this.height = height;
		}
		
		public void AttachTexture(Texture1D tex)
		{
			MakeCurrent();
			OpenGL.glFramebufferTexture1D(OpenGL.Const.GL_FRAMEBUFFER, OpenGL.Const.GL_COLOR_ATTACHMENT0, OpenGL.Const.GL_TEXTURE_1D, tex.Handle, 0);
		}
		public void AttachTexture(Texture2D tex)
		{
			MakeCurrent();
			OpenGL.glFramebufferTexture2D(OpenGL.Const.GL_FRAMEBUFFER, OpenGL.Const.GL_COLOR_ATTACHMENT0, OpenGL.Const.GL_TEXTURE_2D, tex.Handle, 0);
		}
		public void AttachTexture(Texture3D tex, int zoffset)
		{
			MakeCurrent();
			OpenGL.glFramebufferTexture3D(OpenGL.Const.GL_FRAMEBUFFER, OpenGL.Const.GL_COLOR_ATTACHMENT0, OpenGL.Const.GL_TEXTURE_3D, tex.Handle, 0, zoffset);
		}
		public void AttachTexture(CubeTexture tex, CubemapSide side)
		{
			MakeCurrent();
			//OpenGL.glFramebufferTexture(OpenGL.Const.GL_FRAMEBUFFER, OpenGL.Const.GL_COLOR_ATTACHMENT0, tex.Handle, 0, (uint)side);
		}		

		public void MakeCurrent()
		{
			OpenGL.glBindFramebuffer(OpenGL.Const.GL_FRAMEBUFFER, handle);
		}
		public void MakeNonCurrent()
		{
			OpenGL.glBindFramebuffer(OpenGL.Const.GL_FRAMEBUFFER, 0);
		}
		private void Cleanup()
		{
			OpenGL.glDeleteFramebuffers(1, new uint[] { handle });
		}

		public void Dispose()
		{
			Cleanup();
			GC.SuppressFinalize(this);
		}
		~FrameBuffer()
		{
			Cleanup();
		}

	}
}
