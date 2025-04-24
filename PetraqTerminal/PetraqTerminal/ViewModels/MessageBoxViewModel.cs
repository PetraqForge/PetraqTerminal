using System;
using System.Collections.Generic;
using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
	public class MessageBoxViewModel : ReactiveObject
	{
		private string? _message;
		private string? _role;

		public string? Message
		{
			get => _message;
			set
			{
                Console.WriteLine($"[VM] Message set to: {value}");
				this.RaiseAndSetIfChanged(ref _message, value);
			}
		}

		public string? Role
		{
			get => _role;
			set => this.RaiseAndSetIfChanged(ref _role, value);
		}

		public string Background =>
			(Role == "bot") ? "#DDDDDD" : "#EEEEEE";

		public string Position => 
			(Role == "bot") ? "Left" : "Right";

        public MessageBoxViewModel()
        {
            
        }

        public MessageBoxViewModel(string message, string role)
        {
			_role = role;
			_message = message;
        }
    }
}