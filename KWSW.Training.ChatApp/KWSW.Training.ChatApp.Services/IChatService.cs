using System.Collections.Generic;
using KWSW.Training.CharApp.Contracts;

namespace KWSW.Training.ChatApp.Services
{
    public interface IChatService
    {
        Chat Get(int id);
        IEnumerable<Chat> GetAll();
        int GetMessageCount(int chatId);
    }
}