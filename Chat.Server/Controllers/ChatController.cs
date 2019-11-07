using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Business;
using Chat.Interfaces;
using Chat.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private ChatRepository chatRepo;

        public ChatController(ChatRepository repository)
        {
            chatRepo = repository;
        }

        // GET: api/Chat
        [HttpGet]
        public IEnumerable<IChatMessage> Get()
        {
            return chatRepo.GetChatMessages();
        }

        // GET: api/Chat/5
        [HttpGet("{id}", Name = "Get")]
        public IChatMessage Get(int id)
        {
            return chatRepo.GetById(id);
        }

        // POST: api/Chat
        [HttpPost]
        public IChatMessage Post([FromBody] ChatMessage value)
        {
            return chatRepo.AddMessage(value);
        }

        // PUT: api/Chat/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
