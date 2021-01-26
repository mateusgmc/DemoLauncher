using MahApps.Metro.Controls;
using Prism.Services.Dialogs;

namespace DSI.WPF
{
    public class MetroShellWindow : MetroWindow, IDialogWindow
    {
        public IDialogResult Result { get; set; }
    }
}
