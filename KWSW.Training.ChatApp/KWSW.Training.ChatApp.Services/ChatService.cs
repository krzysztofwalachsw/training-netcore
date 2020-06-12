using System.Collections.Generic;
using System.Linq;
using KWSW.Training.CharApp.Contracts;
using KWSW.Training.ChatApp.Data;

namespace KWSW.Training.ChatApp.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatDataProvider _chatDataProvider;
        
        public ChatService(IChatDataProvider chatDataProvider)
        {
            _chatDataProvider = chatDataProvider;
        }

        public Chat Get(int id)
        {
            return _chatDataProvider.Get(id);
        }

        public IEnumerable<Chat> GetAll()
        {
            return _chatDataProvider.GetAll();
        }

        public int GetMessageCount(int chatId)
        {
            var chat = _chatDataProvider.Get(chatId);
            if (chat == null)
            {
                throw new ItemNotFoundException();
            }
            return chat.Messages.Count();
        }
    }
}
