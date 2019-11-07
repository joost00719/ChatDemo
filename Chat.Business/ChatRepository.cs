using Chat.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Chat.Business
{
    public class ChatRepository
    {
        private static Dictionary<int, IChatMessage> _messages = new Dictionary<int, IChatMessage>();

        private static int _nextId = 0;

        private static int getNextId()
        {
            return _nextId++;
        }

        public IEnumerable<IChatMessage> GetChatMessages()
        {
            foreach (var item in _messages)
            {
                yield return item.Value;
            }
        }

        public IChatMessage AddMessage(IChatMessage chatMessage)
        {
            chatMessage.Id = getNextId();
            _messages.Add(chatMessage.Id, chatMessage);

            return chatMessage;
        }

        public IChatMessage GetById(int id)
        {
            return _messages[id];
        }
    }
}
