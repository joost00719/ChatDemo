using Chat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Server.Models
{
    public class ChatMessage : IChatMessage
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string Message { get; set; }

        public Guid SenderId { get; set; }
    }
}
