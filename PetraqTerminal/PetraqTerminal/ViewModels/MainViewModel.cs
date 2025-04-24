using ReactiveUI;
using System.Globalization;

namespace PetraqTerminal.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MenuBarViewModel MenuBar { get; set; } = new();
        public DialogViewModel Dialog { get; set; } = new();
        public static string? Rtl => CultureInfo.CurrentCulture.TextInfo.IsRightToLeft ? "RightToLeft" : "LeftToRight";
    }
}
