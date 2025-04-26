using System;

namespace PetraqTerminal.Models
{
    public interface IMessage
    {
        Guid Id { get; }
        string Content { get; set; }
        string? Sender { get; }
    }
}
