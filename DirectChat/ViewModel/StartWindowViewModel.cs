using System.Collections.Specialized;
using System.Windows.Input;

namespace DirectChat.ViewModel;
public class StartWindowViewModel
{
    public ICommand CloseFormCommand { get; }
    public ICommand RollUpFormCommand { get; }
    public ICommand MovingFormCommand { get; }
}
