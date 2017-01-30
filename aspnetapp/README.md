aspnet-framework:4.6.2 Sample
====================

This sample demonstrates how to dockerize an ASP.NET Web Forms app that uses .NET Framework 4.6.2 by adding a `Dockerfile` to it and running the image with [Docker for Windows](https://docs.docker.com/docker-for-windows/) in a Windows Container. To complete this example you must have [Windows 10 Anniversary Edition](https://www.microsoft.com/en-us/windows/get-windows-10) (or [Windows Server 2016](https://www.microsoft.com/en-us/cloud-platform/windows-server)) with [container support enabled](https://docs.microsoft.com/en-us/virtualization/windowscontainers/quick-start/quick-start-windows-10), [Docker for Windows](https://docs.docker.com/docker-for-windows/) (the minimum beta version 1.13), [Visual Studio](https://www.visualstudio.com/vs/), and [Git](https://git-scm.com/) installed.

## Instructions

> **Note:** You must use Windows Containers on [Docker for Windows](https://docs.docker.com/docker-for-windows/) to run this image. Be sure to check that you are properly switched to Windows Containers. Do this by opening the system tray up arrow and right clicking on the Docker whale icon for a popup menu. In the popup menu make sure you select 'Switch to Windows Containers'. 

### Preparing your Environment

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/microsoft/dotnet-framework-docker-samples/aspnetapp`
2. Build the project locally from [Visual Studio](https://www.visualstudio.com/vs/).
   > **Note:** These instructions are command-line-based for simplicity, but you can also run this sample with [Docker Tools for Visual Studio 2017 RC](https://blogs.msdn.microsoft.com/webdev/2016/11/16/new-docker-tools-for-visual-studio/).

### Build and run the Docker image:

> **Note:** The base image for this sample is [microsoft/iis](https://hub.docker.com/r/microsoft/iis/) which uses [microsoft/windowsservercore](https://hub.docker.com/r/microsoft/windowsservercore/) which is a minimal install of Windows Server 2016 and about 4 GB in size. Make sure you have enough space availiable on your drive.

1. Navigate to the root of your project folder that contains your Dockerfile at the command prompt or terminal.
2. Build the Docker image: `docker build -t aspnetapp .`
3. Run the application in the container: `docker run -d -p 80:80 aspnetapp`

### View your web page running from your container
There is currently a bug that affects how [Windows 10 talks to Containers via "NAT"](https://github.com/Microsoft/Virtualization-Documentation/issues/181#issuecomment-252671828) (Network Address Translation). Today you must hit the IP of the container directly. You can get the IP address of your container with the following steps:
  1. Run `docker ps` and copy the hash of your container ID
  3. Run `docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" HASH` where `HASH` is replaced with your container ID.
  4. Copy the container ip address and paste into your browser with port 80. (Ex: 172.16.240.197:80)