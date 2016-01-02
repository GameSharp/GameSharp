using System;
using System.Windows.Forms;

static partial class Game
{
    static void ShowException(Exception e)
    {
        MessageBox.Show(e.Message + "\n\n" + e.StackTrace, e.Source);
    }

    static void Main()
    {
        try
        {
            Run();
        }
        catch (Exception e)
        {
            ShowException(e);
        }
    }
}
