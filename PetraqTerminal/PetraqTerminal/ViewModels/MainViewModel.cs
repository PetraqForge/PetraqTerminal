using PetraqTerminal.Models;
using PetraqTerminal.Services;
using ReactiveUI;
using System.Globalization;
using System.Reactive;

namespace PetraqTerminal.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IConversationService _conversationService;

        public MainViewModel(IConversationService conversationService)
        {
            _conversationService = conversationService;
            UserInput = new(this);
            SubmitReplyCommand = ReactiveCommand.Create<string?>(SubmitUserInput);
        }

        public MenuBarViewModel MenuBar { get; set; } = new();
        public DialogViewModel Dialog { get; set; } = new();
        public UserInputModel UserInput { get; set; }
        public ReactiveCommand<string?, Unit> SubmitReplyCommand { get; }

        public static string? Rtl => CultureInfo.CurrentCulture.TextInfo.IsRightToLeft ? "RightToLeft" : "LeftToRight";


        private void SubmitUserInput(string? userInputText)
        {
            if ( !string.IsNullOrEmpty(userInputText) )
            {
                var userMessage = new SimpleMessage(userInputText, "user");
                Dialog.MessageBoxes.Add(new MessageBoxViewModel(userMessage));
                UserInput.Text = string.Empty;

                var botMessage = _conversationService.GetReply(userMessage);
                Dialog.MessageBoxes.Add(new MessageBoxViewModel(botMessage));
            }
        }
    }
}
