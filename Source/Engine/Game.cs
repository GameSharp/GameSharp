using System.Threading;

static partial class Game
{
    static bool isExiting = false;

    static void InitSubsystems()
    {
        Log.Init(Parameters.LogName);
        Graphics.Init();            
    }

    static void UpdateSubsystems()
    {
        GameTime.Update();
        Input.Update();
        Graphics.Update();
    }

    static void Run()
    {
        Setup();
        InitSubsystems();
        Start();
        while (!isExiting)
        {
            UpdateSubsystems();
            Update();
            Thread.Sleep(1);
        }
    }

    public static void Exit()
    {
        isExiting = true;
    }
}
