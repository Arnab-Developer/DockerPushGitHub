# Docker push GitHub

[![docker push](https://github.com/Arnab-Developer/DockerPushGitHub/actions/workflows/docker-push.yml/badge.svg)](https://github.com/Arnab-Developer/DockerPushGitHub/actions/workflows/docker-push.yml)
[![pr on main](https://github.com/Arnab-Developer/DockerPushGitHub/actions/workflows/pr-on-main.yml/badge.svg)](https://github.com/Arnab-Developer/DockerPushGitHub/actions/workflows/pr-on-main.yml)

Example .NET app to build and push Docker image to DockerHub with GitHub workflow.

DockerHub repo:
https://hub.docker.com/r/45862391/docker-push-github

Workflow:

- When pull request to main then build and test the code.
- When push to main or merge a pull request to main then build docker image and push to dockerhub.

## Solution structure

* Console app
* Unit test

## Tech stack

* .NET 5
* C# 9
* xUnit for unit testing
* Visual Studio 2019
