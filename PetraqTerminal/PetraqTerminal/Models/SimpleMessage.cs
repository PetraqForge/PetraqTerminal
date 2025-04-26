using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetraqTerminal.Models
{
    class SimpleMessage : IMessage
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Content { get; set; } = string.Empty;
        public string? Sender { get; }

        public SimpleMessage(string content, string sender)
        {
            Content = content;
            Sender = sender;
        }
    }
}
