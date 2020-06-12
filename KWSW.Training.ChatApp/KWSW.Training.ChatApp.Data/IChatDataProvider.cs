using System.Collections.Generic;
using KWSW.Training.CharApp.Contracts;

namespace KWSW.Training.ChatApp.Data
{
    public interface IChatDataProvider
    {
        Chat Get(int id);
        IEnumerable<Chat> GetAll();
    }
}