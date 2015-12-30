using System;

namespace GameSharp
{
    public class Game
    {
        public GameTime GameTime { get; private set; }
    
        bool isExiting = false;
        
        public void Exit()
        {
            isExiting = true;
        }

        public void Run()
        {
            GameTime = new GameTime();
        
            while (!isExiting)
            {
                GameTime.Update();
                Console.WriteLine(GameTime.Step.Milliseconds);
                while (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Escape)
                        Exit();
                }
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
