dotnet-framework:3.5 Sample
====================

The dotnet-framework:3.5 sample demonstrates basic "hello world" usage of .NET Framework 3.5. It shows you how you can build and deploy a project relying on .NET Framework 3.5 in Docker.

Script
------

Follow these steps to try out this sample. They assume that you already have [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

Since the .NET Framework only runs on Windows you must have Docker set to use Windows containers. You can find more information on that here. 

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-framework-docker-samples/dotnetapp-3.5`
2. Navigate to this sample on your machine at the command prompt or terminal. Make sure terminal is open to the same folder that contains the Dockerfile.

**Build and run Docker image**

1. Build the Docker image
   `docker build -t my-dotnet35-app .`
2. Run the application in the container: 
    `docker run my-dotnet35-app`

