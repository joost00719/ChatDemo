using Chat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Chat.Client.Models;
using Microsoft.VisualBasic;

namespace Chat.Client.ViewModels
{
    public class GlobalChatViewModel
    {
        private HttpClient httpClient;

        public GlobalChatViewModel(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public event EventHandler OnMessageReceived;

        public List<IChatMessage> ChatMessages { get; set; }

        public async Task RetrieveChatMessagesAsync()
        {
            ChatMessages = (await httpClient.GetJsonAsync<List<ChatMessageModel>>("http://localhost:46473/api/Chat")).Cast<IChatMessage>().ToList();
        }

        public async Task AddChatMessage(IChatMessage msg)
        {
            var test = await httpClient.PostJsonAsync<ChatMessageModel>("http://localhost:46473/api/Chat", msg);
            ChatMessages.Add(test);
            OnMessageReceived?.Invoke(this, null);
            // instances.ForEach(x => x.OnMessageReceived?.Invoke(this, test));
        }
    }
}
