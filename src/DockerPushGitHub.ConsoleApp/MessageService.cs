namespace DockerPushGitHub.ConsoleApp
{
    internal class MessageService : IMessageService
    {
        string IMessageService.GetMessage()
        {
            return "Hello World from Docker!";
        }
    }
}
