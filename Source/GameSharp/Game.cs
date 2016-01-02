using System;

namespace GameSharp
{
    public static partial class Game
    {
        static bool isExiting = false;
        
        public static void Exit()
        {
            isExiting = true;
        }
        
        private static void InitSubsystems()
        {
            Log.Open("Log.txt");
            Graphics.Init();            
        }

        private static void UpdateSubsystems()
        {
            GameTime.Update();
            Input.Update();
            Graphics.Update();
        }

        public static void Main()
        {
            InitSubsystems();

            while (!isExiting)
            {
                UpdateSubsystems();
                Update();
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
