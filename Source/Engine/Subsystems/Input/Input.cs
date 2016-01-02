using SDL2;

static class Input
{
    static void HandleSDLEvent(SDL.SDL_Event e)
    {
        if (e.type == SDL.SDL_EventType.SDL_QUIT)
        {
            Game.Exit();
        }
        else if (e.type == SDL.SDL_EventType.SDL_KEYDOWN)
        {
            if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_ESCAPE)
                Game.Exit();
        }
    }

    public static void Update()
    {
        SDL.SDL_Event e;
        while (SDL.SDL_PollEvent(out e) != 0)
            HandleSDLEvent(e);
    }
}
