﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glorg2.Graphics.OpenGL.Shaders;
using Glorg2.Graphics.OpenGL;
using Glorg2.Graphics;
using Glorg2;
namespace Glorg2.Graphics
{
	public class Material : Resource.Resource
	{
		List<UniformBase> uniforms;

		Program shader;
		public List<UniformBase> Entries;
		public Program Shader { get { return shader; } set { shader = value; } }

		
	}
}
