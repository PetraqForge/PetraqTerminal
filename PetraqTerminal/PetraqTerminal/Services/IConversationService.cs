using System;
using PetraqTerminal.Models;

namespace PetraqTerminal.Services
{
    public interface IConversationService
    {
        IMessage GetReply(IMessage message);
    }
}
