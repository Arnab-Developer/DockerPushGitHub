using DockerPushGitHub.ConsoleApp;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DockerPushGitHub.ConsoleAppTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

IMessageService messageService = new MessageService();
string message = messageService.GetMessage();
Console.WriteLine(message);
