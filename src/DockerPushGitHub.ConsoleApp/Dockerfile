FROM mcr.microsoft.com/dotnet/runtime:5.0
COPY src/DockerPushGitHub.ConsoleApp/bin/publish/ ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "DockerPushGitHub.ConsoleApp.dll"]