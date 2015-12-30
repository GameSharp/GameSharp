using System;

namespace GameSharp
{
    public class Game
    {
        bool isExiting = false;
        
        public void Exit()
        {
            isExiting = true;
        }

        public void Run()
        {
            while (!isExiting)
            {
                Console.WriteLine("Press Esc");
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
