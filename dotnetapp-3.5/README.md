dotnet-framework:3.5 Sample
====================

The dotnet-framework:3.5 sample demonstrates basic "hello world" usage of .NET Framework 3.5. It shows you how you can build and deploy a project relying on .NET Framework 3.5 in Docker.

Script
------

Follow these steps to try out this sample. To complete this sample you must have [Windows 10](https://www.microsoft.com/en-us/windows/get-windows-10) (or [Windows Server 2016](https://www.microsoft.com/en-us/cloud-platform/windows-server)), [Docker for Windows](https://docs.docker.com/docker-for-windows/), [Visual Studio](https://www.visualstudio.com/vs/), and [Git](https://git-scm.com/) installed.

> **Note:** You must use Windows Containers on [Docker for Windows](https://docs.docker.com/docker-for-windows/) to run this image. Be sure to check that you are properly switched to Windows Containers. Do this by opening the system tray up arrow and right clicking on the Docker whale icon for a popup menu. In the popup menu make sure you select 'Switch to Windows Containers'.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-framework-docker-samples/dotnetapp-3.5`
2. Build the project locally from [Visual Studio](https://www.visualstudio.com/vs/).
3. Navigate to this sample on your machine at the command prompt or terminal. Make sure terminal is open to the same folder that contains the Dockerfile.

**Build and run Docker image**

1. Build the Docker image
   `docker build -t my-dotnet35-app .`
2. Run the application in the container: 
    `docker run my-dotnet35-app`

