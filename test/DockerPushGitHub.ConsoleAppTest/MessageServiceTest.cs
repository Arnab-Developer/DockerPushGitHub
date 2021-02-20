using DockerPushGitHub.ConsoleApp;
using Xunit;

namespace DockerPushGitHub.ConsoleAppTest
{
    public class MessageServiceTest
    {
        private readonly IMessageService _messageService;

        public MessageServiceTest()
        {
            _messageService = new MessageService();
        }

        [Fact]
        public void CanGetMessageReturnProperMessage()
        {
            string message = _messageService.GetMessage();
            Assert.Equal("Push to DockerHub with GitHub workflow.", message);
        }
    }
}
