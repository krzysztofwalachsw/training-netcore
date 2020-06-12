using System;
using System.Collections.Generic;
using System.Linq;
using KWSW.Training.CharApp.Contracts;
using KWSW.Training.ChatApp.Data;
using KWSW.Training.ChatApp.Services;
using Moq;
using Xunit;

namespace KWSW.Training.ChatApp.Tests
{
    public class ChatServiceTests
    {
        private readonly Mock<IChatDataProvider> _chatDataProvider;
        private readonly IChatService _chatService;

        public ChatServiceTests()
        {
            _chatDataProvider = new Mock<IChatDataProvider>();
            _chatService = new ChatService(_chatDataProvider.Object);
        }

        [Fact]
        public void ShouldReturnCountForExistingChat()
        {
            const int chatId = 123;

            var testChatData = new Chat()
            {
                Id = 1,
                Name = "A",
                Messages = new List<Message>()
                {
                    new Message(),
                    new Message(),
                    new Message()
                }
            };
            _chatDataProvider.Setup(p => p.Get(chatId)).Returns(testChatData);

            int result = _chatService.GetMessageCount(chatId);

            Assert.Equal(testChatData.Messages.Count(), result);
        }
        
        [Fact]
        public void ShouldThrowNotFoundForNotExistingChat()
        {
            const int chatId = 123;
            _chatDataProvider.Setup(p => p.Get(chatId)).Returns((Chat)null);

            Assert.Throws<ItemNotFoundException>(() => _chatService.GetMessageCount(chatId));
        }
    }
}
