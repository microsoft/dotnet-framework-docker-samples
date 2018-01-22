# .NET Framework 4.7.1 Console Sample

This .NET Framework Docker sample demonstrates a best practice pattern for building Docker images for .NET Framework apps. It shows you how you can build and deploy the app using Docker. 

The [sample Dockerfile](Dockerfile) creates a .NET Framework application Docker image based off of the [.NET Framework Runtime Docker base image](https://hub.docker.com/r/microsoft/dotnet-framework/).

It uses the [Docker multi-stage build](https://github.com/dotnet/announcements/issues/18) feature to build the sample in a container based on the larger [.NET Framework build base image](https://hub.docker.com/r/microsoft/dotnet-framework-build/) and then copies the final build result into a Docker image based on the smaller [.NET Framework runtime base image](https://hub.docker.com/r/microsoft/dotnet-framework/). The build image contains tools that are required to build applications while the runtime image does not.

## Getting the sample

The easiest way to get the sample is by cloning this repository with git, using the following instructions.

```
git clone https://github.com/Microsoft/dotnet-framework-docker-samples
```

You can also just [download the repository as a zip](https://github.com/Microsoft/dotnet-framework-docker-samples/archive/master.zip).

## Build and run the sample with Docker

You can build and run the sample in Docker using the following commands. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp
docker build -t dotnetapp .
docker run --rm dotnetapp Hello .NET Framework from Docker
```

Note: The instructions above work on multiple versions of Windows. The .NET Framework base images use [multi-arch tags](https://github.com/dotnet/announcements/issues/14), which abstract away [different versions of Windows base images](https://docs.microsoft.com/virtualization/windowscontainers/deploy-containers/version-compatibility).

## Build and run the sample locally with the .NET Core SDK

You can build and run the sample locally with the [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core) using the following instructions. The instructions assume that you are in the root of the repository.

```console
cd dotnetapp-prod
dotnet run Hello .NET Core
```

You can produce an application that is ready to deploy to production locally using the following command.

```console
dotnet publish -c release -o published
```

You can run the application on **Windows** using the following command.

```console
dotnet published\dotnetapp.dll
```

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
