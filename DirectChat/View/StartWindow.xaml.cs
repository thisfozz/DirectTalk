using DirectChat.ViewModel;
using System.Windows;

namespace DirectChat.View;
public partial class StartWindow : Window
{
    public StartWindow()
    {
        InitializeComponent();
        DataContext = new StartWindowViewModel();
    }
}