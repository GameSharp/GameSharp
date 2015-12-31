using System;
using SDL2;
using OpenGL;

namespace GameSharp
{
    public class Graphics
    {
        private IntPtr window;

        public Graphics()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, 2);
            SDL.SDL_GL_SetAttribute(SDL.SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, 1);
            window = SDL.SDL_CreateWindow("GameSharp", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN | SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL);
            var glContext = SDL.SDL_GL_CreateContext(window);
         }
         
         public void Update()
         {
            GL.ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            SDL.SDL_GL_SwapWindow(window);
         }
    }
}
