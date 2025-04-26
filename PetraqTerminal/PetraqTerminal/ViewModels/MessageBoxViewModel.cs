using System;
using System.Collections.Generic;
using PetraqTerminal.Models;
using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
	public class MessageBoxViewModel : ReactiveObject
	{
		private IMessage _message;
		public string? Sender => Message.Sender;
		public string? Content => Message.Content;

		public IMessage Message
		{
			get => _message;
			set
			{
				this.RaiseAndSetIfChanged(ref _message, value);
			}
		}

		public string Background =>
			(Message.Sender == "bot") ? "#DDDDDD" : "#EEEEEE";

		public string Position => 
			(Message.Sender == "bot") ? "Left" : "Right";


        public MessageBoxViewModel(IMessage message)
        {
			_message = message;
        }
    }
}