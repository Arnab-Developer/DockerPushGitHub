namespace DockerPushGitHub.ConsoleApp
{
    internal class MessageService : IMessageService
    {
        string IMessageService.GetMessage()
        {
            return "Push to DockerHub with GitHub workflow.";
        }
    }
}
