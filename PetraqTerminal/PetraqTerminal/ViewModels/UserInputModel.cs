using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
    public class UserInputModel : ViewModelBase
    {
        private string? _text;
        public string? Text {
            get => _text;
            set
            {
                this.RaiseAndSetIfChanged(ref _text, value);
            }
        }


        public ReactiveCommand<Unit, Unit> SubmitReplyCommand { get; }

        public UserInputModel(MainViewModel mainViewModel)
        {
            SubmitReplyCommand = ReactiveCommand.CreateFromObservable(
                () => mainViewModel.SubmitReplyCommand.Execute(Text));
        }
    }
}
