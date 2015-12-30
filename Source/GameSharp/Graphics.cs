using System;
using SDL2;

namespace GameSharp
{
    public class Graphics
    {
        public Graphics()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            var window = SDL.SDL_CreateWindow("GameSharp", SDL.SDL_WINDOWPOS_UNDEFINED, SDL.SDL_WINDOWPOS_UNDEFINED, 800, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            var screenSurface = SDL.SDL_GetWindowSurface(window);
            SDL.SDL_FillRect(screenSurface, IntPtr.Zero, 0xFF);
            SDL.SDL_UpdateWindowSurface(window);
        }
    }
}
