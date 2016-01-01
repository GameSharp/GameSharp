using System;

namespace GameSharp
{
    public class Game
    {
        public Graphics Graphics { get; private set; }
        public Input Input { get; private set; }
    
        bool isExiting = false;
        
        public void Exit()
        {
            isExiting = true;
        }

        public void Run()
        {
            Log.Open("Log.txt");
            Graphics = new Graphics();
            Input = new Input(this);
            
            while (!isExiting)
            {
                GameTime.Update();
                Input.Update();
                Graphics.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
