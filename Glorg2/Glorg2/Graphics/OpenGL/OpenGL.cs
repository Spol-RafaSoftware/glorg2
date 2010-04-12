﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Glorg2.Graphics.OpenGL
{
	public static partial class OpenGL
	{
		

		public const string DllName = "OpenGL32.dll";
		public const CallingConvention CallConv = CallingConvention.Winapi;

		public enum boolean : byte
		{
			TRUE = 1,
			FALSE = 0
		}

		/*************************************************************/



		/* EXT_paletted_texture */



		/*************************************************************/

		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glAccum(uint op, float value);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glAlphaFunc(uint func, float reference);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern boolean glAreTexturesResident(int n, uint[] textures, boolean[] residences);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glArrayElement(int i);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glBegin(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glBindTexture(uint target, uint texture);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glBlendFunc(uint sfactor, uint dfactor);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCallList(uint list);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glCallLists(int n, uint type, void* lists);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClear(uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClearAccum(float red, float green, float blue, float alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClearColor(float red, float green, float blue, float alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClearDepth(double depth);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClearIndex(float c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClearStencil(int s);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glClipPlane(uint plane, double[] equation);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3b(sbyte red, sbyte green, sbyte blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3bv(sbyte[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3d(double red, double green, double blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3f(float red, float green, float blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3i(int red, int green, int blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3s(short red, short green, short blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3ub(byte red, byte green, byte blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3ubv(byte[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3ui(uint red, uint green, uint blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3uiv(uint[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3us(ushort red, ushort green, ushort blue);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor3usv(ushort[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4bv(sbyte[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4d(double red, double green, double blue, double alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4f(float red, float green, float blue, float alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4i(int red, int green, int blue, int alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4s(short red, short green, short blue, short alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4ubv(byte[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4uiv(uint[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColor4usv(ushort[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColorMask(boolean red, boolean green, boolean blue, boolean alpha);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColorMaterial(uint face, uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glColorPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCopyPixels(int x, int y, int width, int height, uint type);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glCullFace(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDeleteLists(uint list, int range);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDeleteTextures(int n, uint[] textures);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDepthFunc(uint func);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDepthMask(boolean flag);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDepthRange(double zNear, double zFar);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDisable(uint cap);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDisableClientState(uint array);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDrawArrays(uint mode, int first, int count);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDrawBuffer(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glDrawElements(uint mode, int count, uint type, IntPtr indices);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glDrawPixels(int width, int height, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEdgeFlag(boolean flag);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glEdgeFlagPointer(int stride, void* pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEdgeFlagv(boolean[] flag);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEnable(uint cap);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEnableClientState(uint array);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEnd();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEndList();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord1d(double u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord1dv(double[] u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord1f(float u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord1fv(float[] u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord2d(double u, double v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord2dv(double[] u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord2f(float u, float v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalCoord2fv(float[] u);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalMesh1(uint mode, int i1, int i2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalPoint1(int i);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glEvalPoint2(int i, int j);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFeedbackBuffer(int size, uint type, float[] buffer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFinish();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFlush();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFogf(uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFogfv(uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFogi(uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFogiv(uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFrontFace(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern uint glGenLists(int range);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGenTextures(int n, uint[] textures);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetBooleanv(uint pname, boolean[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetClipPlane(uint plane, double[] equation);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetDoublev(uint pname, double[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern uint glGetError();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetFloatv(uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetFloatv(uint pname, ref Matrix parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glGetFloatv(uint pname, float* parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetIntegerv(uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetLightfv(uint light, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetLightiv(uint light, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetMapdv(uint target, uint query, double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetMapfv(uint target, uint query, float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetMapiv(uint target, uint query, int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetMaterialfv(uint face, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetMaterialiv(uint face, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetPixelMapfv(uint map, float[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetPixelMapuiv(uint map, uint[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetPixelMapusv(uint map, ushort[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glGetPointerv(uint pname, void** par);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetPolygonStipple(byte[] mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern IntPtr glGetString(uint name);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexEnvfv(uint target, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexEnviv(uint target, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexGendv(uint coord, uint pname, double[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexGenfv(uint coord, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexGeniv(uint coord, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glGetTexImage(uint target, int level, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexParameterfv(uint target, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glGetTexParameteriv(uint target, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glHint(uint target, uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexMask(uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glIndexPointer(uint type, int stride, void* pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexd(double c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexdv(double[] c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexf(float c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexfv(float[] c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexi(int c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexiv(int[] c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexs(short c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexsv(short[] c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexub(byte c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glIndexubv(byte[] c);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glInitNames();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glInterleavedArrays(uint format, int stride, void* pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern boolean glIsEnabled(uint cap);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern boolean glIsList(uint list);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern boolean glIsTexture(uint texture);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightModelf(uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightModelfv(uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightModeli(uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightModeliv(uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightf(uint light, uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightfv(uint light, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLighti(uint light, uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLightiv(uint light, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLineStipple(int factor, ushort pattern);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLineWidth(float width);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glListBase(uint base_index);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLoadIdentity();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLoadMatrixd(double[] m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLoadMatrixf(float[] m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLoadMatrixf(ref Matrix m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glLoadMatrixf(float* m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLoadName(uint name);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glLogicOp(uint opcode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMap1d(uint target, double u1, double u2, int stride, int order, double[] points);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMap1f(uint target, float u1, float u2, int stride, int order, float[] points);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMapGrid1d(int un, double u1, double u2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMapGrid1f(int un, float u1, float u2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMaterialf(uint face, uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMaterialfv(uint face, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMateriali(uint face, uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMaterialiv(uint face, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMatrixMode(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMultMatrixd(double[] m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glMultMatrixf(float[] m);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNewList(uint list, uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3bv(sbyte[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3d(double nx, double ny, double nz);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3f(float nx, float ny, float nz);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3i(int nx, int ny, int nz);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3s(short nx, short ny, short nz);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormal3sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glNormalPointer(uint type, int stride, IntPtr pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPassThrough(float token);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelMapfv(uint map, int mapsize, float[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelMapuiv(uint map, int mapsize, uint[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelMapusv(uint map, int mapsize, ushort[] values);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelStoref(uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelStorei(uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelTransferf(uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelTransferi(uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPixelZoom(float xfactor, float yfactor);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPointSize(float size);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPolygonMode(uint face, uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPolygonOffset(float factor, float units);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPolygonStipple(byte[] mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPopAttrib();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPopClientAttrib();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPopMatrix();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPopName();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPrioritizeTextures(int n, uint[] textures, float[] priorities);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPushAttrib(uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPushClientAttrib(uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPushMatrix();
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glPushName(uint name);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2d(double x, double y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2f(float x, float y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2i(int x, int y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2s(short x, short y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos2sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3d(double x, double y, double z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3f(float x, float y, float z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3i(int x, int y, int z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3s(short x, short y, short z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos3sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4d(double x, double y, double z, double w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4f(float x, float y, float z, float w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4i(int x, int y, int z, int w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4s(short x, short y, short z, short w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRasterPos4sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glReadBuffer(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectd(double x1, double y1, double x2, double y2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectdv(double[] v1, double[] v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectf(float x1, float y1, float x2, float y2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectfv(float[] v1, float[] v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRecti(int x1, int y1, int x2, int y2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectiv(int[] v1, int[] v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRects(short x1, short y1, short x2, short y2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRectsv(short[] v1, short[] v2);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern int glRenderMode(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRotated(double angle, double x, double y, double z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glRotatef(float angle, float x, float y, float z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glScaled(double x, double y, double z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glScalef(float x, float y, float z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glScissor(int x, int y, int width, int height);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glSelectBuffer(int size, uint[] buffer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glShadeModel(uint mode);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glStencilFunc(uint func, int reference, uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glStencilMask(uint mask);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glStencilOp(uint fail, uint zfail, uint zpass);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1d(double s);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1f(float s);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1i(int s);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1s(short s);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord1sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2d(double s, double t);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2f(float s, float t);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2i(int s, int t);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2s(short s, short t);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord2sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3d(double s, double t, double r);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3f(float s, float t, float r);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3i(int s, int t, int r);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3s(short s, short t, short r);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord3sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4d(double s, double t, double r, double q);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4f(float s, float t, float r, float q);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4i(int s, int t, int r, int q);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4s(short s, short t, short r, short q);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoord4sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexCoordPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexEnvf(uint target, uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexEnvfv(uint target, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexEnvi(uint target, uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexEnviv(uint target, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGend(uint coord, uint pname, double param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGendv(uint coord, uint pname, double[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGenf(uint coord, uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGenfv(uint coord, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGeni(uint coord, uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexGeniv(uint coord, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexParameterf(uint target, uint pname, float param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexParameterfv(uint target, uint pname, float[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexParameteri(uint target, uint pname, int param);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTexParameteriv(uint target, uint pname, int[] parameters);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static unsafe extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTranslated(double x, double y, double z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glTranslatef(float x, float y, float z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2d(double x, double y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2f(float x, float y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2i(int x, int y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2s(short x, short y);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex2sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3d(double x, double y, double z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3f(float x, float y, float z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3i(int x, int y, int z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3s(short x, short y, short z);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex3sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4d(double x, double y, double z, double w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4dv(double[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4f(float x, float y, float z, float w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4fv(float[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4i(int x, int y, int z, int w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4iv(int[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4s(short x, short y, short z, short w);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertex4sv(short[] v);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glVertexPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(DllName, CallingConvention = CallConv)]
		public static extern void glViewport(int x, int y, int width, int height);


		public static string GetString(int name)
		{
			return Marshal.PtrToStringAnsi(glGetString((uint)name));
		}


	}
}
