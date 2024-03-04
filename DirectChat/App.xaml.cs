using DirectChat.View;
using System.Windows;

namespace DirectChat;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var startWindow = new StartWindow();
        startWindow.Show();
    }
}
