using SDL2;

namespace GameSharp
{
    public class Input
    {
        private Game game;
        
        public Input(Game game)
        {
            this.game = game;
        }
        
        public void Update()
        {
            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e) != 0)
                HandleSDLEvent(e);
        }
        
        void HandleSDLEvent(SDL.SDL_Event e)
        {
            if (e.type == SDL.SDL_EventType.SDL_QUIT)
            {
                game.Exit();
            }
            else if (e.type == SDL.SDL_EventType.SDL_KEYDOWN)
            {
                if (e.key.keysym.sym == SDL.SDL_Keycode.SDLK_ESCAPE)
                    game.Exit();
            }
        }
    }
}
