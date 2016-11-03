dotnet-framework:4.6.2 Sample
====================

The dotnet-framework:4.6.2 sample demonstrates basic "hello world" usage of the .NET Framework 4.6.2. It shows you how you can build and deploy the app relying on the .NET Framework 4.6.2.

Script
------

Follow these steps to try out this sample. They assume that you already have [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

Since the .NET Framework only runs on Windows you must have Docker set to use Windows containers. You can find more information on that here. 

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-framework-docker-samples/dotnetapp-4.6.2`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and run Docker image**

1. Build the Docker image
   `docker build -t my-dotnet46-app .`
2. Run the application in the container: 
    `docker run my-dotnet46-app`
