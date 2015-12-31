using System;

namespace GameSharp
{
    public class Game
    {
        public GameTime GameTime { get; private set; }
        public Graphics Graphics { get; private set; }
        public Input Input { get; private set; }
    
        bool isExiting = false;
        
        public void Exit()
        {
            isExiting = true;
        }

        public void Run()
        {
            GameTime = new GameTime();
            Graphics = new Graphics();
            Input = new Input(this);
        
            while (!isExiting)
            {
                GameTime.Update();
                Input.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
