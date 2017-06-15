dotnet-framework:4.7 Sample
====================

The dotnet-framework:4.7 sample demonstrates basic "hello world" usage of the .NET Framework 4.7. It shows you how you can build and deploy the app relying on the .NET Framework 4.7 docker image.

Script
------

Follow these steps to try out this sample. To complete this sample you must have [Windows 10](https://www.microsoft.com/en-us/windows/get-windows-10) (or [Windows Server 2016](https://www.microsoft.com/en-us/cloud-platform/windows-server)), [Docker for Windows](https://docs.docker.com/docker-for-windows/), [Visual Studio](https://www.visualstudio.com/vs/), and [Git](https://git-scm.com/) installed.

> **Note:** You must use Windows Containers on [Docker for Windows](https://docs.docker.com/docker-for-windows/) to run this image. Be sure to check that you are properly switched to Windows Containers. Do this by opening the system tray up arrow and right clicking on the Docker whale icon for a popup menu. In the popup menu make sure you select 'Switch to Windows Containers'.

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-framework-docker-samples/dotnetapp-4.7`
2. Build the project locally
    - Build from [Visual Studio 2017](https://www.visualstudio.com/vs/) in release mode.
    - Build with the [.NET Core CLI](https://www.microsoft.com/net/download/core):
       - `dotnet restore`
       - `dotnet build -c release`

**Build and run Docker image**

Navigate to this sample on your machine at the command prompt. Make sure command prompt is open to the same folder that contains the Dockerfile.

1. Build the Docker image
   `docker build -t dotnet47-app .`
2. Run the application in the container: 
    `docker run dotnet47-app`
