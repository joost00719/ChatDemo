using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Interfaces
{
    public interface IChatMessage
    {
        Guid SenderId { get; set; }

        int Id { get; set; }

        string Sender { get; set; }

        string Message { get; set; }
    }
}
