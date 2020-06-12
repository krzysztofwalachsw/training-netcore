using System;
using System.Collections.Generic;
using KWSW.Training.CharApp.Contracts;

namespace KWSW.Training.ChatApp.Data
{
    public class HardcodedChatDataProvider : IChatDataProvider
    {
        public Chat Get(int id)
        {
            var model = new Chat()
            {
                Name = $"Chat room {id}",
                Messages = new List<Message>()
                {
                    new Message()
                        {Id = 101, AuthorName = "Mr X", Text = "Hello from X", TimePosted = DateTime.Now.AddHours(-2)},
                    new Message()
                        {Id = 102, AuthorName = "Mr Y", Text = "Hello from Y", TimePosted = DateTime.Now.AddHours(-1)},
                    new Message()
                        {Id = 103, AuthorName = "Mr Z", Text = "Hello from Z", TimePosted = DateTime.Now.AddHours(0)},
                }
            };
            return model;
        }

        public IEnumerable<Chat> GetAll()
        {
            var model = new List<Chat>()
            {
                new Chat() {Id = 1, Name = "Chat room 1"},
                new Chat() {Id = 2, Name = "Chat room 2"},
            };
            return model;
        }
    }
}
