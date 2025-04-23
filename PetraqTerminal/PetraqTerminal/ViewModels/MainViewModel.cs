using ReactiveUI;
using System.Globalization;

namespace PetraqTerminal.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public static string? Rtl => CultureInfo.CurrentCulture.TextInfo.IsRightToLeft ? "RightToLeft" : "LeftToRight";
    }
}
