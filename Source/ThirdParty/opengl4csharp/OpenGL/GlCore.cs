// Modified by 1nanK for GameSharp

using System;
using System.Runtime.InteropServices;

namespace OpenGL
{
    partial class GL
    {
        //const string Library = "libGL.so.1"; // linux
        const string Library = "opengl32.dll"; // mac os x and windows

        [DllImport(Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
        public static extern void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
        [DllImport(Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
        public static extern void ActiveTexture(OpenGL.TextureUnit texture);
        [DllImport(Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
        public static extern void AttachShader(UInt32 program, UInt32 shader);
        [DllImport(Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
        public static extern void BeginConditionalRender(UInt32 id, OpenGL.ConditionalRenderType mode);
        [DllImport(Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
        public static extern void EndConditionalRender();
        [DllImport(Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
        public static extern void BeginQuery(OpenGL.QueryTarget target, UInt32 id);
        [DllImport(Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
        public static extern void EndQuery(OpenGL.QueryTarget target);
        [DllImport(Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
        public static extern void BeginQueryIndexed(UInt32 target, UInt32 index, UInt32 id);
        [DllImport(Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
        public static extern void EndQueryIndexed(OpenGL.QueryTarget target, UInt32 index);
        [DllImport(Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
        public static extern void BeginTransformFeedback(OpenGL.BeginFeedbackMode primitiveMode);
        [DllImport(Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
        public static extern void EndTransformFeedback();
        [DllImport(Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
        public static extern void BindAttribLocation(UInt32 program, UInt32 index, String name);
        [DllImport(Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
        public static extern void BindBuffer(OpenGL.BufferTarget target, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
        public static extern void BindBufferBase(OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
        public static extern void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
        [DllImport(Library, EntryPoint = "glBindBuffersBase", ExactSpelling = true)]
        public static extern void BindBuffersBase(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers);
        [DllImport(Library, EntryPoint = "glBindBuffersRange", ExactSpelling = true)]
        public static extern void BindBuffersRange(OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes);
        [DllImport(Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
        public static extern void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name);
        [DllImport(Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
        public static extern void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
        [DllImport(Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
        public static extern void BindFramebuffer(OpenGL.FramebufferTarget target, UInt32 framebuffer);
        [DllImport(Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
        public static extern void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, OpenGL.BufferAccess access, OpenGL.PixelInternalFormat format);
        [DllImport(Library, EntryPoint = "glBindImageTextures", ExactSpelling = true)]
        public static extern void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures);
        [DllImport(Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
        public static extern void BindProgramPipeline(UInt32 pipeline);
        [DllImport(Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
        public static extern void BindRenderbuffer(OpenGL.RenderbufferTarget target, UInt32 renderbuffer);
        [DllImport(Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
        public static extern void BindSampler(UInt32 unit, UInt32 sampler);
        [DllImport(Library, EntryPoint = "glBindSamplers", ExactSpelling = true)]
        public static extern void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers);
        [DllImport(Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
        public static extern void BindTexture(OpenGL.TextureTarget target, UInt32 texture);
        [DllImport(Library, EntryPoint = "glBindTextures", ExactSpelling = true)]
        public static extern void BindTextures(UInt32 first, Int32 count, UInt32[] textures);
        [DllImport(Library, EntryPoint = "glBindTextureUnit", ExactSpelling = true)]
        public static extern void BindTextureUnit(UInt32 unit, UInt32 texture);
        [DllImport(Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
        public static extern void BindTransformFeedback(OpenGL.NvTransformFeedback2 target, UInt32 id);
        [DllImport(Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
        public static extern void BindVertexArray(UInt32 array);
        [DllImport(Library, EntryPoint = "glBindVertexBuffer", ExactSpelling = true)]
        public static extern void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride);
        [DllImport(Library, EntryPoint = "glVertexArrayVertexBuffer", ExactSpelling = true)]
        public static extern void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
        [DllImport(Library, EntryPoint = "glBindVertexBuffers", ExactSpelling = true)]
        public static extern void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
        [DllImport(Library, EntryPoint = "glVertexArrayVertexBuffers", ExactSpelling = true)]
        public static extern void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
        [DllImport(Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
        public static extern void BlendColor(Single red, Single green, Single blue, Single alpha);
        [DllImport(Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
        public static extern void BlendEquation(OpenGL.BlendEquationMode mode);
        [DllImport(Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
        public static extern void BlendEquationi(UInt32 buf, OpenGL.BlendEquationMode mode);
        [DllImport(Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
        public static extern void BlendEquationSeparate(OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);
        [DllImport(Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
        public static extern void BlendEquationSeparatei(UInt32 buf, OpenGL.BlendEquationMode modeRGB, OpenGL.BlendEquationMode modeAlpha);
        [DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
        public static extern void BlendFunc(OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);
        [DllImport(Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
        public static extern void BlendFunci(UInt32 buf, OpenGL.BlendingFactorSrc sfactor, OpenGL.BlendingFactorDest dfactor);
        [DllImport(Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
        public static extern void BlendFuncSeparate(OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);
        [DllImport(Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
        public static extern void BlendFuncSeparatei(UInt32 buf, OpenGL.BlendingFactorSrc srcRGB, OpenGL.BlendingFactorDest dstRGB, OpenGL.BlendingFactorSrc srcAlpha, OpenGL.BlendingFactorDest dstAlpha);
        [DllImport(Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
        public static extern void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);
        [DllImport(Library, EntryPoint = "glBlitNamedFramebuffer", ExactSpelling = true)]
        public static extern void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, OpenGL.ClearBufferMask mask, OpenGL.BlitFramebufferFilter filter);
        [DllImport(Library, EntryPoint = "glBufferData", ExactSpelling = true)]
        public static extern void BufferData(OpenGL.BufferTarget target, IntPtr size, IntPtr data, OpenGL.BufferUsageHint usage);
        [DllImport(Library, EntryPoint = "glNamedBufferData", ExactSpelling = true)]
        public static extern void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, OpenGL.BufferUsageHint usage);
        [DllImport(Library, EntryPoint = "glBufferStorage", ExactSpelling = true)]
        public static extern void BufferStorage(OpenGL.BufferTarget target, IntPtr size, IntPtr data, UInt32 flags);
        [DllImport(Library, EntryPoint = "glNamedBufferStorage", ExactSpelling = true)]
        public static extern void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags);
        [DllImport(Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
        public static extern void BufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
        [DllImport(Library, EntryPoint = "glNamedBufferSubData", ExactSpelling = true)]
        public static extern void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data);
        [DllImport(Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
        public static extern OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenGL.FramebufferTarget target);
        [DllImport(Library, EntryPoint = "glCheckNamedFramebufferStatus", ExactSpelling = true)]
        public static extern OpenGL.FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, OpenGL.FramebufferTarget target);
        [DllImport(Library, EntryPoint = "glClampColor", ExactSpelling = true)]
        public static extern void ClampColor(OpenGL.ClampColorTarget target, OpenGL.ClampColorMode clamp);
        [DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
        public static extern void Clear(OpenGL.ClearBufferMask mask);
        [DllImport(Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
        public static extern void ClearBufferiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
        [DllImport(Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
        public static extern void ClearBufferuiv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
        [DllImport(Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
        public static extern void ClearBufferfv(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
        [DllImport(Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
        public static extern void ClearBufferfi(OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
        [DllImport(Library, EntryPoint = "glClearNamedFramebufferiv", ExactSpelling = true)]
        public static extern void ClearNamedFramebufferiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
        [DllImport(Library, EntryPoint = "glClearNamedFramebufferuiv", ExactSpelling = true)]
        public static extern void ClearNamedFramebufferuiv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
        [DllImport(Library, EntryPoint = "glClearNamedFramebufferfv", ExactSpelling = true)]
        public static extern void ClearNamedFramebufferfv(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
        [DllImport(Library, EntryPoint = "glClearNamedFramebufferfi", ExactSpelling = true)]
        public static extern void ClearNamedFramebufferfi(UInt32 framebuffer, OpenGL.ClearBuffer buffer, Single depth, Int32 stencil);
        [DllImport(Library, EntryPoint = "glClearBufferData", ExactSpelling = true)]
        public static extern void ClearBufferData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClearNamedBufferData", ExactSpelling = true)]
        public static extern void ClearNamedBufferData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClearBufferSubData", ExactSpelling = true)]
        public static extern void ClearBufferSubData(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClearNamedBufferSubData", ExactSpelling = true)]
        public static extern void ClearNamedBufferSubData(UInt32 buffer, OpenGL.SizedInternalFormat internalFormat, IntPtr offset, Int32 size, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
        public static extern void ClearColor(Single red, Single green, Single blue, Single alpha);
        [DllImport(Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
        public static extern void ClearDepth(Double depth);
        [DllImport(Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
        public static extern void ClearDepthf(Single depth);
        [DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
        public static extern void ClearStencil(Int32 s);
        [DllImport(Library, EntryPoint = "glClearTexImage", ExactSpelling = true)]
        public static extern void ClearTexImage(UInt32 texture, Int32 level, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClearTexSubImage", ExactSpelling = true)]
        public static extern void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
        public static extern OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
        [DllImport(Library, EntryPoint = "glClipControl", ExactSpelling = true)]
        public static extern void ClipControl(OpenGL.ClipControlOrigin origin, OpenGL.ClipControlDepth depth);
        [DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
        public static extern void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);
        [DllImport(Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
        public static extern void ColorMaski(UInt32 buf, Boolean red, Boolean green, Boolean blue, Boolean alpha);
        [DllImport(Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
        public static extern void CompileShader(UInt32 shader);
        [DllImport(Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
        public static extern void CompressedTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
        public static extern void CompressedTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
        public static extern void CompressedTexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
        public static extern void CompressedTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTextureSubImage1D", ExactSpelling = true)]
        public static extern void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
        public static extern void CompressedTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTextureSubImage2D", ExactSpelling = true)]
        public static extern void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
        public static extern void CompressedTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCompressedTextureSubImage3D", ExactSpelling = true)]
        public static extern void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
        [DllImport(Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
        public static extern void CopyBufferSubData(OpenGL.BufferTarget readTarget, OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        [DllImport(Library, EntryPoint = "glCopyNamedBufferSubData", ExactSpelling = true)]
        public static extern void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size);
        [DllImport(Library, EntryPoint = "glCopyImageSubData", ExactSpelling = true)]
        public static extern void CopyImageSubData(UInt32 srcName, OpenGL.BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, OpenGL.BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
        [DllImport(Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
        public static extern void CopyTexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border);
        [DllImport(Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
        public static extern void CopyTexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [DllImport(Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
        public static extern void CopyTexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        [DllImport(Library, EntryPoint = "glCopyTextureSubImage1D", ExactSpelling = true)]
        public static extern void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
        [DllImport(Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
        public static extern void CopyTexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glCopyTextureSubImage2D", ExactSpelling = true)]
        public static extern void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
        public static extern void CopyTexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glCopyTextureSubImage3D", ExactSpelling = true)]
        public static extern void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glCreateBuffers", ExactSpelling = true)]
        public static extern void CreateBuffers(Int32 n, UInt32[] buffers);
        [DllImport(Library, EntryPoint = "glCreateFramebuffers", ExactSpelling = true)]
        public static extern void CreateFramebuffers(Int32 n, UInt32[] ids);
        [DllImport(Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
        public static extern UInt32 CreateProgram();
        [DllImport(Library, EntryPoint = "glCreateProgramPipelines", ExactSpelling = true)]
        public static extern void CreateProgramPipelines(Int32 n, UInt32[] pipelines);
        [DllImport(Library, EntryPoint = "glCreateQueries", ExactSpelling = true)]
        public static extern void CreateQueries(OpenGL.QueryTarget target, Int32 n, UInt32[] ids);
        [DllImport(Library, EntryPoint = "glCreateRenderbuffers", ExactSpelling = true)]
        public static extern void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers);
        [DllImport(Library, EntryPoint = "glCreateSamplers", ExactSpelling = true)]
        public static extern void CreateSamplers(Int32 n, UInt32[] samplers);
        [DllImport(Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
        public static extern UInt32 CreateShader(OpenGL.ShaderType shaderType);
        [DllImport(Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
        public static extern UInt32 CreateShaderProgramv(OpenGL.ShaderType type, Int32 count, String strings);
        [DllImport(Library, EntryPoint = "glCreateTextures", ExactSpelling = true)]
        public static extern void CreateTextures(OpenGL.TextureTarget target, Int32 n, UInt32[] textures);
        [DllImport(Library, EntryPoint = "glCreateTransformFeedbacks", ExactSpelling = true)]
        public static extern void CreateTransformFeedbacks(Int32 n, UInt32[] ids);
        [DllImport(Library, EntryPoint = "glCreateVertexArrays", ExactSpelling = true)]
        public static extern void CreateVertexArrays(Int32 n, UInt32[] arrays);
        [DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
        public static extern void CullFace(OpenGL.CullFaceMode mode);
        [DllImport(Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
        public static extern void DeleteBuffers(Int32 n, UInt32[] buffers);
        [DllImport(Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
        public static extern void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);
        [DllImport(Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
        public static extern void DeleteProgram(UInt32 program);
        [DllImport(Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
        public static extern void DeleteProgramPipelines(Int32 n, UInt32[] pipelines);
        [DllImport(Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
        public static extern void DeleteQueries(Int32 n, UInt32[] ids);
        [DllImport(Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
        public static extern void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);
        [DllImport(Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
        public static extern void DeleteSamplers(Int32 n, UInt32[] samplers);
        [DllImport(Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
        public static extern void DeleteShader(UInt32 shader);
        [DllImport(Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
        public static extern void DeleteSync(IntPtr sync);
        [DllImport(Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
        public static extern void DeleteTextures(Int32 n, UInt32[] textures);
        [DllImport(Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
        public static extern void DeleteTransformFeedbacks(Int32 n, UInt32[] ids);
        [DllImport(Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
        public static extern void DeleteVertexArrays(Int32 n, UInt32[] arrays);
        [DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
        public static extern void DepthFunc(OpenGL.DepthFunction func);
        [DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
        public static extern void DepthMask(Boolean flag);
        [DllImport(Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
        public static extern void DepthRange(Double nearVal, Double farVal);
        [DllImport(Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
        public static extern void DepthRangef(Single nearVal, Single farVal);
        [DllImport(Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
        public static extern void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v);
        [DllImport(Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
        public static extern void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal);
        [DllImport(Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
        public static extern void DetachShader(UInt32 program, UInt32 shader);
        [DllImport(Library, EntryPoint = "glDispatchCompute", ExactSpelling = true)]
        public static extern void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
        [DllImport(Library, EntryPoint = "glDispatchComputeIndirect", ExactSpelling = true)]
        public static extern void DispatchComputeIndirect(IntPtr indirect);
        [DllImport(Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
        public static extern void DrawArrays(OpenGL.BeginMode mode, Int32 first, Int32 count);
        [DllImport(Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
        public static extern void DrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect);
        [DllImport(Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
        public static extern void DrawArraysInstanced(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
        [DllImport(Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
        public static extern void DrawArraysInstancedBaseInstance(OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance);
        [DllImport(Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
        public static extern void DrawBuffer(OpenGL.DrawBufferMode buf);
        [DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffer", ExactSpelling = true)]
        public static extern void NamedFramebufferDrawBuffer(UInt32 framebuffer, OpenGL.DrawBufferMode buf);
        [DllImport(Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
        public static extern void DrawBuffers(Int32 n, OpenGL.DrawBuffersEnum[] bufs);
        [DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffers", ExactSpelling = true)]
        public static extern void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, OpenGL.DrawBufferMode[] bufs);
        [DllImport(Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
        public static extern void DrawElements(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);
        [DllImport(Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
        public static extern void DrawElementsBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
        [DllImport(Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
        public static extern void DrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect);
        [DllImport(Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
        public static extern void DrawElementsInstanced(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
        [DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
        public static extern void DrawElementsInstancedBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance);
        [DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
        public static extern void DrawElementsInstancedBaseVertex(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);
        [DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
        public static extern void DrawElementsInstancedBaseVertexBaseInstance(OpenGL.BeginMode mode, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance);
        [DllImport(Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
        public static extern void DrawRangeElements(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices);
        [DllImport(Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
        public static extern void DrawRangeElementsBaseVertex(OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
        [DllImport(Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
        public static extern void DrawTransformFeedback(OpenGL.NvTransformFeedback2 mode, UInt32 id);
        [DllImport(Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
        public static extern void DrawTransformFeedbackInstanced(OpenGL.BeginMode mode, UInt32 id, Int32 primcount);
        [DllImport(Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
        public static extern void DrawTransformFeedbackStream(OpenGL.NvTransformFeedback2 mode, UInt32 id, UInt32 stream);
        [DllImport(Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
        public static extern void DrawTransformFeedbackStreamInstanced(OpenGL.BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount);
        [DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
        public static extern void Enable(OpenGL.EnableCap cap);
        [DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
        public static extern void Disable(OpenGL.EnableCap cap);
        [DllImport(Library, EntryPoint = "glEnablei", ExactSpelling = true)]
        public static extern void Enablei(OpenGL.EnableCap cap, UInt32 index);
        [DllImport(Library, EntryPoint = "glDisablei", ExactSpelling = true)]
        public static extern void Disablei(OpenGL.EnableCap cap, UInt32 index);
        [DllImport(Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
        public static extern void EnableVertexAttribArray(UInt32 index);
        [DllImport(Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
        public static extern void DisableVertexAttribArray(UInt32 index);
        [DllImport(Library, EntryPoint = "glEnableVertexArrayAttrib", ExactSpelling = true)]
        public static extern void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
        [DllImport(Library, EntryPoint = "glDisableVertexArrayAttrib", ExactSpelling = true)]
        public static extern void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
        [DllImport(Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
        public static extern IntPtr FenceSync(OpenGL.ArbSync condition, UInt32 flags);
        [DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
        public static extern void Finish();
        [DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
        public static extern void Flush();
        [DllImport(Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
        public static extern void FlushMappedBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length);
        [DllImport(Library, EntryPoint = "glFlushMappedNamedBufferRange", ExactSpelling = true)]
        public static extern void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length);
        [DllImport(Library, EntryPoint = "glFramebufferParameteri", ExactSpelling = true)]
        public static extern void FramebufferParameteri(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, Int32 param);
        [DllImport(Library, EntryPoint = "glNamedFramebufferParameteri", ExactSpelling = true)]
        public static extern void NamedFramebufferParameteri(UInt32 framebuffer, OpenGL.FramebufferPName pname, Int32 param);
        [DllImport(Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
        public static extern void FramebufferRenderbuffer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
        [DllImport(Library, EntryPoint = "glNamedFramebufferRenderbuffer", ExactSpelling = true)]
        public static extern void NamedFramebufferRenderbuffer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
        [DllImport(Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
        public static extern void FramebufferTexture(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
        [DllImport(Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
        public static extern void FramebufferTexture1D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
        [DllImport(Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
        public static extern void FramebufferTexture2D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
        [DllImport(Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
        public static extern void FramebufferTexture3D(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer);
        [DllImport(Library, EntryPoint = "glNamedFramebufferTexture", ExactSpelling = true)]
        public static extern void NamedFramebufferTexture(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
        [DllImport(Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
        public static extern void FramebufferTextureLayer(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
        [DllImport(Library, EntryPoint = "glNamedFramebufferTextureLayer", ExactSpelling = true)]
        public static extern void NamedFramebufferTextureLayer(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
        [DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
        public static extern void FrontFace(OpenGL.FrontFaceDirection mode);
        [DllImport(Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
        public static extern void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);
        [DllImport(Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
        public static extern void GenerateMipmap(OpenGL.GenerateMipmapTarget target);
        [DllImport(Library, EntryPoint = "glGenerateTextureMipmap", ExactSpelling = true)]
        public static extern void GenerateTextureMipmap(UInt32 texture);
        [DllImport(Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
        public static extern void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] ids);
        [DllImport(Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
        public static extern void GenProgramPipelines(Int32 n, [OutAttribute] UInt32[] pipelines);
        [DllImport(Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
        public static extern void GenQueries(Int32 n, [OutAttribute] UInt32[] ids);
        [DllImport(Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
        public static extern void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);
        [DllImport(Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
        public static extern void GenSamplers(Int32 n, [OutAttribute] UInt32[] samplers);
        [DllImport(Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
        public static extern void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);
        [DllImport(Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
        public static extern void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32[] ids);
        [DllImport(Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
        public static extern void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays);
        [DllImport(Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
        public static extern void GetBooleanv(OpenGL.GetPName pname, [OutAttribute] Boolean[] data);
        [DllImport(Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
        public static extern void GetDoublev(OpenGL.GetPName pname, [OutAttribute] Double[] data);
        [DllImport(Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
        public static extern void GetFloatv(OpenGL.GetPName pname, [OutAttribute] Single[] data);
        [DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
        public static extern void GetIntegerv(OpenGL.GetPName pname, [OutAttribute] Int32[] data);
        [DllImport(Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
        public static extern void GetInteger64v(OpenGL.ArbSync pname, [OutAttribute] Int64[] data);
        [DllImport(Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
        public static extern void GetBooleani_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Boolean[] data);
        [DllImport(Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
        public static extern void GetIntegeri_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int32[] data);
        [DllImport(Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
        public static extern void GetFloati_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Single[] data);
        [DllImport(Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
        public static extern void GetDoublei_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Double[] data);
        [DllImport(Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
        public static extern void GetInteger64i_v(OpenGL.GetPName target, UInt32 index, [OutAttribute] Int64[] data);
        [DllImport(Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
        public static extern void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, OpenGL.AtomicCounterParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
        public static extern void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
        public static extern void GetActiveSubroutineName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
        public static extern void GetActiveSubroutineUniformiv(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, OpenGL.SubroutineParameterName pname, [OutAttribute] Int32[] values);
        [DllImport(Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
        public static extern void GetActiveSubroutineUniformName(UInt32 program, OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
        public static extern void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveUniformType[] type, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
        public static extern void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, OpenGL.ActiveUniformBlockParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
        public static extern void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformBlockName);
        [DllImport(Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
        public static extern void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformName);
        [DllImport(Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
        public static extern void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, [OutAttribute] UInt32[] uniformIndices, OpenGL.ActiveUniformType pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
        public static extern void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32[] count, [OutAttribute] UInt32[] shaders);
        [DllImport(Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
        public static extern Int32 GetAttribLocation(UInt32 program, String name);
        [DllImport(Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
        public static extern void GetBufferParameteriv(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int32[] data);
        [DllImport(Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
        public static extern void GetBufferParameteri64v(OpenGL.BufferTarget target, OpenGL.BufferParameterName value, [OutAttribute] Int64[] data);
        [DllImport(Library, EntryPoint = "glGetNamedBufferParameteriv", ExactSpelling = true)]
        public static extern void GetNamedBufferParameteriv(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetNamedBufferParameteri64v", ExactSpelling = true)]
        public static extern void GetNamedBufferParameteri64v(UInt32 buffer, OpenGL.BufferParameterName pname, [OutAttribute] Int64[] @params);
        [DllImport(Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
        public static extern void GetBufferPointerv(OpenGL.BufferTarget target, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);
        [DllImport(Library, EntryPoint = "glGetNamedBufferPointerv", ExactSpelling = true)]
        public static extern void GetNamedBufferPointerv(UInt32 buffer, OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);
        [DllImport(Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
        public static extern void GetBufferSubData(OpenGL.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
        [DllImport(Library, EntryPoint = "glGetNamedBufferSubData", ExactSpelling = true)]
        public static extern void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, [OutAttribute] IntPtr data);
        [DllImport(Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
        public static extern void GetCompressedTexImage(OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetnCompressedTexImage", ExactSpelling = true)]
        public static extern void GetnCompressedTexImage(OpenGL.TextureTarget target, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetCompressedTextureImage", ExactSpelling = true)]
        public static extern void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetCompressedTextureSubImage", ExactSpelling = true)]
        public static extern void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
        public static extern OpenGL.ErrorCode GetError();
        [DllImport(Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
        public static extern Int32 GetFragDataIndex(UInt32 program, String name);
        [DllImport(Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
        public static extern Int32 GetFragDataLocation(UInt32 program, String name);
        [DllImport(Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
        public static extern void GetFramebufferAttachmentParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", ExactSpelling = true)]
        public static extern void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, OpenGL.FramebufferAttachment attachment, OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetFramebufferParameteriv", ExactSpelling = true)]
        public static extern void GetFramebufferParameteriv(OpenGL.FramebufferTarget target, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetNamedFramebufferParameteriv", ExactSpelling = true)]
        public static extern void GetNamedFramebufferParameteriv(UInt32 framebuffer, OpenGL.FramebufferPName pname, [OutAttribute] Int32[] param);
        [DllImport(Library, EntryPoint = "glGetGraphicsResetStatus", ExactSpelling = true)]
        public static extern OpenGL.GraphicResetStatus GetGraphicsResetStatus();
        [DllImport(Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
        public static extern void GetInternalformativ(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetInternalformati64v", ExactSpelling = true)]
        public static extern void GetInternalformati64v(OpenGL.TextureTarget target, OpenGL.PixelInternalFormat internalFormat, OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int64[] @params);
        [DllImport(Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
        public static extern void GetMultisamplefv(OpenGL.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single[] val);
        [DllImport(Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
        public static extern void GetObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 bifSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);
        [DllImport(Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
        public static extern void GetObjectPtrLabel([OutAttribute] IntPtr ptr, Int32 bifSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);
        [DllImport(Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
        public static extern void GetPointerv(OpenGL.GetPointerParameter pname, [OutAttribute] IntPtr @params);
        [DllImport(Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
        public static extern void GetProgramiv(UInt32 program, OpenGL.ProgramParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
        public static extern void GetProgramBinary(UInt32 program, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] binaryFormat, [OutAttribute] IntPtr binary);
        [DllImport(Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
        public static extern void GetProgramInfoLog(UInt32 program, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
        [DllImport(Library, EntryPoint = "glGetProgramInterfaceiv", ExactSpelling = true)]
        public static extern void GetProgramInterfaceiv(UInt32 program, OpenGL.ProgramInterface programInterface, OpenGL.ProgramInterfaceParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
        public static extern void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
        public static extern void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
        [DllImport(Library, EntryPoint = "glGetProgramResourceiv", ExactSpelling = true)]
        public static extern void GetProgramResourceiv(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 propCount, [OutAttribute] OpenGL.ProgramResourceParameterName[] props, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetProgramResourceIndex", ExactSpelling = true)]
        public static extern UInt32 GetProgramResourceIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
        [DllImport(Library, EntryPoint = "glGetProgramResourceLocation", ExactSpelling = true)]
        public static extern Int32 GetProgramResourceLocation(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
        [DllImport(Library, EntryPoint = "glGetProgramResourceLocationIndex", ExactSpelling = true)]
        public static extern Int32 GetProgramResourceLocationIndex(UInt32 program, OpenGL.ProgramInterface programInterface, String name);
        [DllImport(Library, EntryPoint = "glGetProgramResourceName", ExactSpelling = true)]
        public static extern void GetProgramResourceName(UInt32 program, OpenGL.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
        public static extern void GetProgramStageiv(UInt32 program, OpenGL.ShaderType shadertype, OpenGL.ProgramStageParameterName pname, [OutAttribute] Int32[] values);
        [DllImport(Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
        public static extern void GetQueryIndexediv(OpenGL.QueryTarget target, UInt32 index, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
        public static extern void GetQueryiv(OpenGL.QueryTarget target, OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
        public static extern void GetQueryObjectiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
        public static extern void GetQueryObjectuiv(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
        public static extern void GetQueryObjecti64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] Int64[] @params);
        [DllImport(Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
        public static extern void GetQueryObjectui64v(UInt32 id, OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt64[] @params);
        [DllImport(Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
        public static extern void GetRenderbufferParameteriv(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetNamedRenderbufferParameteriv", ExactSpelling = true)]
        public static extern void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
        public static extern void GetSamplerParameterfv(UInt32 sampler, Int32 pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
        public static extern void GetSamplerParameteriv(UInt32 sampler, Int32 pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
        public static extern void GetSamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
        public static extern void GetSamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
        public static extern void GetShaderiv(UInt32 shader, OpenGL.ShaderParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
        public static extern void GetShaderInfoLog(UInt32 shader, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
        [DllImport(Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
        public static extern void GetShaderPrecisionFormat(OpenGL.ShaderType shaderType, Int32 precisionType, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);
        [DllImport(Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
        public static extern void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder source);
        [DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
        public static extern IntPtr GetString(OpenGL.StringName name);
        [DllImport(Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
        public static extern IntPtr GetStringi(OpenGL.StringName name, UInt32 index);
        [DllImport(Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
        public static extern UInt32 GetSubroutineIndex(UInt32 program, OpenGL.ShaderType shadertype, String name);
        [DllImport(Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
        public static extern Int32 GetSubroutineUniformLocation(UInt32 program, OpenGL.ShaderType shadertype, String name);
        [DllImport(Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
        public static extern void GetSynciv(IntPtr sync, OpenGL.ArbSync pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values);
        [DllImport(Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
        public static extern void GetTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetnTexImage", ExactSpelling = true)]
        public static extern void GetnTexImage(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetTextureImage", ExactSpelling = true)]
        public static extern void GetTextureImage(UInt32 texture, Int32 level, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
        public static extern void GetTexLevelParameterfv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
        public static extern void GetTexLevelParameteriv(OpenGL.GetPName target, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureLevelParameterfv", ExactSpelling = true)]
        public static extern void GetTextureLevelParameterfv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureLevelParameteriv", ExactSpelling = true)]
        public static extern void GetTextureLevelParameteriv(UInt32 texture, Int32 level, OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
        public static extern void GetTexParameterfv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
        public static extern void GetTexParameteriv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
        public static extern void GetTexParameterIiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
        public static extern void GetTexParameterIuiv(OpenGL.TextureTarget target, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureParameterfv", ExactSpelling = true)]
        public static extern void GetTextureParameterfv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureParameteriv", ExactSpelling = true)]
        public static extern void GetTextureParameteriv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureParameterIiv", ExactSpelling = true)]
        public static extern void GetTextureParameterIiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureParameterIuiv", ExactSpelling = true)]
        public static extern void GetTextureParameterIuiv(UInt32 texture, OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetTextureSubImage", ExactSpelling = true)]
        public static extern void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
        [DllImport(Library, EntryPoint = "glGetTransformFeedbackiv", ExactSpelling = true)]
        public static extern void GetTransformFeedbackiv(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, [OutAttribute] Int32[] param);
        [DllImport(Library, EntryPoint = "glGetTransformFeedbacki_v", ExactSpelling = true)]
        public static extern void GetTransformFeedbacki_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int32[] param);
        [DllImport(Library, EntryPoint = "glGetTransformFeedbacki64_v", ExactSpelling = true)]
        public static extern void GetTransformFeedbacki64_v(UInt32 xfb, OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int64[] param);
        [DllImport(Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
        public static extern void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);
        [DllImport(Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
        public static extern void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
        public static extern void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
        public static extern void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
        public static extern void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double[] @params);
        [DllImport(Library, EntryPoint = "glGetnUniformfv", ExactSpelling = true)]
        public static extern void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetnUniformiv", ExactSpelling = true)]
        public static extern void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetnUniformuiv", ExactSpelling = true)]
        public static extern void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetnUniformdv", ExactSpelling = true)]
        public static extern void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double[] @params);
        [DllImport(Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
        public static extern UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
        [DllImport(Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
        public static extern void GetUniformIndices(UInt32 program, Int32 uniformCount, String uniformNames, [OutAttribute] UInt32[] uniformIndices);
        [DllImport(Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
        public static extern Int32 GetUniformLocation(UInt32 program, String name);
        [DllImport(Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
        public static extern void GetUniformSubroutineuiv(OpenGL.ShaderType shadertype, Int32 location, [OutAttribute] UInt32[] values);
        [DllImport(Library, EntryPoint = "glGetVertexArrayIndexed64iv", ExactSpelling = true)]
        public static extern void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int64[] param);
        [DllImport(Library, EntryPoint = "glGetVertexArrayIndexediv", ExactSpelling = true)]
        public static extern void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);
        [DllImport(Library, EntryPoint = "glGetVertexArrayiv", ExactSpelling = true)]
        public static extern void GetVertexArrayiv(UInt32 vaobj, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);
        [DllImport(Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
        public static extern void GetVertexAttribdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
        public static extern void GetVertexAttribfv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Single[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
        public static extern void GetVertexAttribiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
        public static extern void GetVertexAttribIiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
        public static extern void GetVertexAttribIuiv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] UInt32[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
        public static extern void GetVertexAttribLdv(UInt32 index, OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);
        [DllImport(Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
        public static extern void GetVertexAttribPointerv(UInt32 index, OpenGL.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
        [DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
        public static extern void Hint(OpenGL.HintTarget target, OpenGL.HintMode mode);
        [DllImport(Library, EntryPoint = "glInvalidateBufferData", ExactSpelling = true)]
        public static extern void InvalidateBufferData(UInt32 buffer);
        [DllImport(Library, EntryPoint = "glInvalidateBufferSubData", ExactSpelling = true)]
        public static extern void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
        [DllImport(Library, EntryPoint = "glInvalidateFramebuffer", ExactSpelling = true)]
        public static extern void InvalidateFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);
        [DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferData", ExactSpelling = true)]
        public static extern void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments);
        [DllImport(Library, EntryPoint = "glInvalidateSubFramebuffer", ExactSpelling = true)]
        public static extern void InvalidateSubFramebuffer(OpenGL.FramebufferTarget target, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferSubData", ExactSpelling = true)]
        public static extern void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glInvalidateTexImage", ExactSpelling = true)]
        public static extern void InvalidateTexImage(UInt32 texture, Int32 level);
        [DllImport(Library, EntryPoint = "glInvalidateTexSubImage", ExactSpelling = true)]
        public static extern void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
        [DllImport(Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
        public static extern Boolean IsBuffer(UInt32 buffer);
        [DllImport(Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
        public static extern Boolean IsEnabled(OpenGL.EnableCap cap);
        [DllImport(Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
        public static extern Boolean IsEnabledi(OpenGL.EnableCap cap, UInt32 index);
        [DllImport(Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
        public static extern Boolean IsFramebuffer(UInt32 framebuffer);
        [DllImport(Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
        public static extern Boolean IsProgram(UInt32 program);
        [DllImport(Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
        public static extern Boolean IsProgramPipeline(UInt32 pipeline);
        [DllImport(Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
        public static extern Boolean IsQuery(UInt32 id);
        [DllImport(Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
        public static extern Boolean IsRenderbuffer(UInt32 renderbuffer);
        [DllImport(Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
        public static extern Boolean IsSampler(UInt32 id);
        [DllImport(Library, EntryPoint = "glIsShader", ExactSpelling = true)]
        public static extern Boolean IsShader(UInt32 shader);
        [DllImport(Library, EntryPoint = "glIsSync", ExactSpelling = true)]
        public static extern Boolean IsSync(IntPtr sync);
        [DllImport(Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
        public static extern Boolean IsTexture(UInt32 texture);
        [DllImport(Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
        public static extern Boolean IsTransformFeedback(UInt32 id);
        [DllImport(Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
        public static extern Boolean IsVertexArray(UInt32 array);
        [DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
        public static extern void LineWidth(Single width);
        [DllImport(Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
        public static extern void LinkProgram(UInt32 program);
        [DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
        public static extern void LogicOp(OpenGL.LogicOp opcode);
        [DllImport(Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
        public static extern IntPtr MapBuffer(OpenGL.BufferTarget target, OpenGL.BufferAccess access);
        [DllImport(Library, EntryPoint = "glMapNamedBuffer", ExactSpelling = true)]
        public static extern IntPtr MapNamedBuffer(UInt32 buffer, OpenGL.BufferAccess access);
        [DllImport(Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
        public static extern IntPtr MapBufferRange(OpenGL.BufferTarget target, IntPtr offset, IntPtr length, OpenGL.BufferAccessMask access);
        [DllImport(Library, EntryPoint = "glMapNamedBufferRange", ExactSpelling = true)]
        public static extern IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access);
        [DllImport(Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
        public static extern void MemoryBarrier(UInt32 barriers);
        [DllImport(Library, EntryPoint = "glMemoryBarrierByRegion", ExactSpelling = true)]
        public static extern void MemoryBarrierByRegion(UInt32 barriers);
        [DllImport(Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
        public static extern void MinSampleShading(Single value);
        [DllImport(Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
        public static extern void MultiDrawArrays(OpenGL.BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount);
        [DllImport(Library, EntryPoint = "glMultiDrawArraysIndirect", ExactSpelling = true)]
        public static extern void MultiDrawArraysIndirect(OpenGL.BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride);
        [DllImport(Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
        public static extern void MultiDrawElements(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount);
        [DllImport(Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
        public static extern void MultiDrawElementsBaseVertex(OpenGL.BeginMode mode, Int32[] count, OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex);
        [DllImport(Library, EntryPoint = "glMultiDrawElementsIndirect", ExactSpelling = true)]
        public static extern void MultiDrawElementsIndirect(OpenGL.BeginMode mode, OpenGL.DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);
        [DllImport(Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
        public static extern void ObjectLabel(OpenGL.ObjectLabel identifier, UInt32 name, Int32 length, String label);
        [DllImport(Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
        public static extern void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
        [DllImport(Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
        public static extern void PatchParameteri(Int32 pname, Int32 value);
        [DllImport(Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
        public static extern void PatchParameterfv(Int32 pname, Single[] values);
        [DllImport(Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
        public static extern void PixelStoref(OpenGL.PixelStoreParameter pname, Single param);
        [DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
        public static extern void PixelStorei(OpenGL.PixelStoreParameter pname, Int32 param);
        [DllImport(Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
        public static extern void PointParameterf(OpenGL.PointParameterName pname, Single param);
        [DllImport(Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
        public static extern void PointParameteri(OpenGL.PointParameterName pname, Int32 param);
        [DllImport(Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
        public static extern void PointParameterfv(OpenGL.PointParameterName pname, Single[] @params);
        [DllImport(Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
        public static extern void PointParameteriv(OpenGL.PointParameterName pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
        public static extern void PointSize(Single size);
        [DllImport(Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
        public static extern void PolygonMode(OpenGL.MaterialFace face, OpenGL.PolygonMode mode);
        [DllImport(Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
        public static extern void PolygonOffset(Single factor, Single units);
        [DllImport(Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
        public static extern void PrimitiveRestartIndex(UInt32 index);
        [DllImport(Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
        public static extern void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);
        [DllImport(Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
        public static extern void ProgramParameteri(UInt32 program, OpenGL.Version32 pname, Int32 value);
        [DllImport(Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
        public static extern void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
        [DllImport(Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
        public static extern void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
        [DllImport(Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
        public static extern void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
        [DllImport(Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
        public static extern void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
        [DllImport(Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
        public static extern void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
        [DllImport(Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
        public static extern void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
        [DllImport(Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
        public static extern void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
        [DllImport(Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
        public static extern void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        [DllImport(Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
        public static extern void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
        [DllImport(Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
        public static extern void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1);
        [DllImport(Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
        public static extern void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2);
        [DllImport(Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
        public static extern void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3);
        [DllImport(Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
        public static extern void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
        public static extern void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
        public static extern void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
        public static extern void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
        public static extern void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
        public static extern void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
        public static extern void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
        public static extern void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
        public static extern void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
        public static extern void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
        public static extern void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
        public static extern void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
        public static extern void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
        public static extern void ProvokingVertex(OpenGL.ProvokingVertexMode provokeMode);
        [DllImport(Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
        public static extern void QueryCounter(UInt32 id, Int32 target);
        [DllImport(Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
        public static extern void ReadBuffer(OpenGL.ReadBufferMode mode);
        [DllImport(Library, EntryPoint = "glNamedFramebufferReadBuffer", ExactSpelling = true)]
        public static extern void NamedFramebufferReadBuffer(UInt32 framebuffer, OpenGL.BeginMode mode);
        [DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
        public static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32[] data);
        [DllImport(Library, EntryPoint = "glReadnPixels", ExactSpelling = true)]
        public static extern void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, Int32 bufSize, Int32[] data);
        [DllImport(Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
        public static extern void RenderbufferStorage(OpenGL.RenderbufferTarget target, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glNamedRenderbufferStorage", ExactSpelling = true)]
        public static extern void NamedRenderbufferStorage(UInt32 renderbuffer, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
        public static extern void RenderbufferStorageMultisample(OpenGL.RenderbufferTarget target, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisample", ExactSpelling = true)]
        public static extern void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
        public static extern void SampleCoverage(Single value, Boolean invert);
        [DllImport(Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
        public static extern void SampleMaski(UInt32 maskNumber, UInt32 mask);
        [DllImport(Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
        public static extern void SamplerParameterf(UInt32 sampler, Int32 pname, Single param);
        [DllImport(Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
        public static extern void SamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);
        [DllImport(Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
        public static extern void SamplerParameterfv(UInt32 sampler, Int32 pname, Single[] @params);
        [DllImport(Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
        public static extern void SamplerParameteriv(UInt32 sampler, Int32 pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
        public static extern void SamplerParameterIiv(UInt32 sampler, OpenGL.TextureParameterName pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
        public static extern void SamplerParameterIuiv(UInt32 sampler, OpenGL.TextureParameterName pname, UInt32[] @params);
        [DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
        public static extern void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
        public static extern void ScissorArrayv(UInt32 first, Int32 count, Int32[] v);
        [DllImport(Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
        public static extern void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
        public static extern void ScissorIndexedv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
        public static extern void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length);
        [DllImport(Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
        public static extern void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);
        [DllImport(Library, EntryPoint = "glShaderStorageBlockBinding", ExactSpelling = true)]
        public static extern void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
        [DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
        public static extern void StencilFunc(OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
        [DllImport(Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
        public static extern void StencilFuncSeparate(OpenGL.StencilFace face, OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
        [DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
        public static extern void StencilMask(UInt32 mask);
        [DllImport(Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
        public static extern void StencilMaskSeparate(OpenGL.StencilFace face, UInt32 mask);
        [DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
        public static extern void StencilOp(OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);
        [DllImport(Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
        public static extern void StencilOpSeparate(OpenGL.StencilFace face, OpenGL.StencilOp sfail, OpenGL.StencilOp dpfail, OpenGL.StencilOp dppass);
        [DllImport(Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
        public static extern void TexBuffer(OpenGL.TextureBufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glTextureBuffer", ExactSpelling = true)]
        public static extern void TextureBuffer(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glTexBufferRange", ExactSpelling = true)]
        public static extern void TexBufferRange(OpenGL.BufferTarget target, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size);
        [DllImport(Library, EntryPoint = "glTextureBufferRange", ExactSpelling = true)]
        public static extern void TextureBufferRange(UInt32 texture, OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size);
        [DllImport(Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
        public static extern void TexImage1D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
        public static extern void TexImage2D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
        public static extern void TexImage2DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
        public static extern void TexImage3D(OpenGL.TextureTarget target, Int32 level, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr data);
        [DllImport(Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
        public static extern void TexImage3DMultisample(OpenGL.TextureTargetMultisample target, Int32 samples, OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
        public static extern void TexParameterf(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single param);
        [DllImport(Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
        public static extern void TexParameteri(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32 param);
        [DllImport(Library, EntryPoint = "glTextureParameterf", ExactSpelling = true)]
        public static extern void TextureParameterf(UInt32 texture, OpenGL.TextureParameter pname, Single param);
        [DllImport(Library, EntryPoint = "glTextureParameteri", ExactSpelling = true)]
        public static extern void TextureParameteri(UInt32 texture, OpenGL.TextureParameter pname, Int32 param);
        [DllImport(Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
        public static extern void TexParameterfv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Single[] @params);
        [DllImport(Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
        public static extern void TexParameteriv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
        public static extern void TexParameterIiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
        public static extern void TexParameterIuiv(OpenGL.TextureTarget target, OpenGL.TextureParameterName pname, UInt32[] @params);
        [DllImport(Library, EntryPoint = "glTextureParameterfv", ExactSpelling = true)]
        public static extern void TextureParameterfv(UInt32 texture, OpenGL.TextureParameter pname, Single[] paramtexture);
        [DllImport(Library, EntryPoint = "glTextureParameteriv", ExactSpelling = true)]
        public static extern void TextureParameteriv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] param);
        [DllImport(Library, EntryPoint = "glTextureParameterIiv", ExactSpelling = true)]
        public static extern void TextureParameterIiv(UInt32 texture, OpenGL.TextureParameter pname, Int32[] @params);
        [DllImport(Library, EntryPoint = "glTextureParameterIuiv", ExactSpelling = true)]
        public static extern void TextureParameterIuiv(UInt32 texture, OpenGL.TextureParameter pname, UInt32[] @params);
        [DllImport(Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
        public static extern void TexStorage1D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);
        [DllImport(Library, EntryPoint = "glTextureStorage1D", ExactSpelling = true)]
        public static extern void TextureStorage1D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width);
        [DllImport(Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
        public static extern void TexStorage2D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glTextureStorage2D", ExactSpelling = true)]
        public static extern void TextureStorage2D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glTexStorage2DMultisample", ExactSpelling = true)]
        public static extern void TexStorage2DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTextureStorage2DMultisample", ExactSpelling = true)]
        public static extern void TextureStorage2DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
        public static extern void TexStorage3D(OpenGL.TextureTarget target, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
        [DllImport(Library, EntryPoint = "glTextureStorage3D", ExactSpelling = true)]
        public static extern void TextureStorage3D(UInt32 texture, Int32 levels, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
        [DllImport(Library, EntryPoint = "glTexStorage3DMultisample", ExactSpelling = true)]
        public static extern void TexStorage3DMultisample(OpenGL.TextureTarget target, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTextureStorage3DMultisample", ExactSpelling = true)]
        public static extern void TextureStorage3DMultisample(UInt32 texture, Int32 samples, OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
        [DllImport(Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
        public static extern void TexSubImage1D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTextureSubImage1D", ExactSpelling = true)]
        public static extern void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
        public static extern void TexSubImage2D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTextureSubImage2D", ExactSpelling = true)]
        public static extern void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
        public static extern void TexSubImage3D(OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTextureSubImage3D", ExactSpelling = true)]
        public static extern void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenGL.PixelFormat format, OpenGL.PixelType type, IntPtr pixels);
        [DllImport(Library, EntryPoint = "glTextureBarrier", ExactSpelling = true)]
        public static extern void TextureBarrier();
        [DllImport(Library, EntryPoint = "glTextureView", ExactSpelling = true)]
        public static extern void TextureView(UInt32 texture, OpenGL.TextureTarget target, UInt32 origtexture, OpenGL.PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
        [DllImport(Library, EntryPoint = "glTransformFeedbackBufferBase", ExactSpelling = true)]
        public static extern void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glTransformFeedbackBufferRange", ExactSpelling = true)]
        public static extern void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size);
        [DllImport(Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
        public static extern void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, OpenGL.TransformFeedbackMode bufferMode);
        [DllImport(Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
        public static extern void Uniform1f(Int32 location, Single v0);
        [DllImport(Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
        public static extern void Uniform2f(Int32 location, Single v0, Single v1);
        [DllImport(Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
        public static extern void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
        [DllImport(Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
        public static extern void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
        [DllImport(Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
        public static extern void Uniform1i(Int32 location, Int32 v0);
        [DllImport(Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
        public static extern void Uniform2i(Int32 location, Int32 v0, Int32 v1);
        [DllImport(Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
        public static extern void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
        [DllImport(Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
        public static extern void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        [DllImport(Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
        public static extern void Uniform1ui(Int32 location, UInt32 v0);
        [DllImport(Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
        public static extern void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
        [DllImport(Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
        public static extern void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
        [DllImport(Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
        public static extern void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
        [DllImport(Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
        public static extern void Uniform1fv(Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
        public static extern void Uniform2fv(Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
        public static extern void Uniform3fv(Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
        public static extern void Uniform4fv(Int32 location, Int32 count, Single[] value);
        [DllImport(Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
        public static extern void Uniform1iv(Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
        public static extern void Uniform2iv(Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
        public static extern void Uniform3iv(Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
        public static extern void Uniform4iv(Int32 location, Int32 count, Int32[] value);
        [DllImport(Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
        public static extern void Uniform1uiv(Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
        public static extern void Uniform2uiv(Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
        public static extern void Uniform3uiv(Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
        public static extern void Uniform4uiv(Int32 location, Int32 count, UInt32[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
        public static extern void UniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
        public static extern void UniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
        public static extern void UniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
        public static extern void UniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
        public static extern void UniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
        public static extern void UniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
        public static extern void UniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
        public static extern void UniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
        public static extern void UniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
        [DllImport(Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
        public static extern void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
        [DllImport(Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
        public static extern void UniformSubroutinesuiv(OpenGL.ShaderType shadertype, Int32 count, UInt32[] indices);
        [DllImport(Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
        public static extern Boolean UnmapBuffer(OpenGL.BufferTarget target);
        [DllImport(Library, EntryPoint = "glUnmapNamedBuffer", ExactSpelling = true)]
        public static extern Boolean UnmapNamedBuffer(UInt32 buffer);
        [DllImport(Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
        public static extern void UseProgram(UInt32 program);
        [DllImport(Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
        public static extern void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);
        [DllImport(Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
        public static extern void ValidateProgram(UInt32 program);
        [DllImport(Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
        public static extern void ValidateProgramPipeline(UInt32 pipeline);
        [DllImport(Library, EntryPoint = "glVertexArrayElementBuffer", ExactSpelling = true)]
        public static extern void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);
        [DllImport(Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
        public static extern void VertexAttrib1f(UInt32 index, Single v0);
        [DllImport(Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
        public static extern void VertexAttrib1s(UInt32 index, Int16 v0);
        [DllImport(Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
        public static extern void VertexAttrib1d(UInt32 index, Double v0);
        [DllImport(Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
        public static extern void VertexAttribI1i(UInt32 index, Int32 v0);
        [DllImport(Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
        public static extern void VertexAttribI1ui(UInt32 index, UInt32 v0);
        [DllImport(Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
        public static extern void VertexAttrib2f(UInt32 index, Single v0, Single v1);
        [DllImport(Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
        public static extern void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1);
        [DllImport(Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
        public static extern void VertexAttrib2d(UInt32 index, Double v0, Double v1);
        [DllImport(Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
        public static extern void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1);
        [DllImport(Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
        public static extern void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1);
        [DllImport(Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
        public static extern void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2);
        [DllImport(Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
        public static extern void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2);
        [DllImport(Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
        public static extern void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2);
        [DllImport(Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
        public static extern void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2);
        [DllImport(Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
        public static extern void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2);
        [DllImport(Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
        public static extern void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3);
        [DllImport(Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
        public static extern void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3);
        [DllImport(Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
        public static extern void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
        public static extern void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3);
        [DllImport(Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
        public static extern void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
        [DllImport(Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
        public static extern void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
        [DllImport(Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
        public static extern void VertexAttribL1d(UInt32 index, Double v0);
        [DllImport(Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
        public static extern void VertexAttribL2d(UInt32 index, Double v0, Double v1);
        [DllImport(Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
        public static extern void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2);
        [DllImport(Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
        public static extern void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
        [DllImport(Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
        public static extern void VertexAttrib1fv(UInt32 index, Single[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
        public static extern void VertexAttrib1sv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
        public static extern void VertexAttrib1dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
        public static extern void VertexAttribI1iv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
        public static extern void VertexAttribI1uiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
        public static extern void VertexAttrib2fv(UInt32 index, Single[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
        public static extern void VertexAttrib2sv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
        public static extern void VertexAttrib2dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
        public static extern void VertexAttribI2iv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
        public static extern void VertexAttribI2uiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
        public static extern void VertexAttrib3fv(UInt32 index, Single[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
        public static extern void VertexAttrib3sv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
        public static extern void VertexAttrib3dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
        public static extern void VertexAttribI3iv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
        public static extern void VertexAttribI3uiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
        public static extern void VertexAttrib4fv(UInt32 index, Single[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
        public static extern void VertexAttrib4sv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
        public static extern void VertexAttrib4dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
        public static extern void VertexAttrib4iv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
        public static extern void VertexAttrib4bv(UInt32 index, SByte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
        public static extern void VertexAttrib4ubv(UInt32 index, Byte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
        public static extern void VertexAttrib4usv(UInt32 index, UInt16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
        public static extern void VertexAttrib4uiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
        public static extern void VertexAttrib4Nbv(UInt32 index, SByte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
        public static extern void VertexAttrib4Nsv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
        public static extern void VertexAttrib4Niv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
        public static extern void VertexAttrib4Nubv(UInt32 index, Byte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
        public static extern void VertexAttrib4Nusv(UInt32 index, UInt16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
        public static extern void VertexAttrib4Nuiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
        public static extern void VertexAttribI4bv(UInt32 index, SByte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
        public static extern void VertexAttribI4ubv(UInt32 index, Byte[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
        public static extern void VertexAttribI4sv(UInt32 index, Int16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
        public static extern void VertexAttribI4usv(UInt32 index, UInt16[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
        public static extern void VertexAttribI4iv(UInt32 index, Int32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
        public static extern void VertexAttribI4uiv(UInt32 index, UInt32[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
        public static extern void VertexAttribL1dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
        public static extern void VertexAttribL2dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
        public static extern void VertexAttribL3dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
        public static extern void VertexAttribL4dv(UInt32 index, Double[] v);
        [DllImport(Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
        public static extern void VertexAttribP1ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
        [DllImport(Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
        public static extern void VertexAttribP2ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
        [DllImport(Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
        public static extern void VertexAttribP3ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
        [DllImport(Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
        public static extern void VertexAttribP4ui(UInt32 index, OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
        [DllImport(Library, EntryPoint = "glVertexAttribBinding", ExactSpelling = true)]
        public static extern void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
        [DllImport(Library, EntryPoint = "glVertexArrayAttribBinding", ExactSpelling = true)]
        public static extern void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);
        [DllImport(Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
        public static extern void VertexAttribDivisor(UInt32 index, UInt32 divisor);
        [DllImport(Library, EntryPoint = "glVertexAttribFormat", ExactSpelling = true)]
        public static extern void VertexAttribFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexAttribIFormat", ExactSpelling = true)]
        public static extern void VertexAttribIFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexAttribLFormat", ExactSpelling = true)]
        public static extern void VertexAttribLFormat(UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexArrayAttribFormat", ExactSpelling = true)]
        public static extern void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexArrayAttribIFormat", ExactSpelling = true)]
        public static extern void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexArrayAttribLFormat", ExactSpelling = true)]
        public static extern void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
        [DllImport(Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
        public static extern void VertexAttribPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer);
        [DllImport(Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
        public static extern void VertexAttribIPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
        [DllImport(Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
        public static extern void VertexAttribLPointer(UInt32 index, Int32 size, OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
        [DllImport(Library, EntryPoint = "glVertexBindingDivisor", ExactSpelling = true)]
        public static extern void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
        [DllImport(Library, EntryPoint = "glVertexArrayBindingDivisor", ExactSpelling = true)]
        public static extern void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);
        [DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
        public static extern void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
        [DllImport(Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
        public static extern void ViewportArrayv(UInt32 first, Int32 count, Single[] v);
        [DllImport(Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
        public static extern void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
        [DllImport(Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
        public static extern void ViewportIndexedfv(UInt32 index, Single[] v);
        [DllImport(Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
        public static extern void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
    }
}
