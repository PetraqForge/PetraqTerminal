using System;
using PetraqTerminal.Models;

namespace PetraqTerminal.Services
{
    interface IConversationService
    {
        IMessage GetReply(IMessage message);
    }
}
