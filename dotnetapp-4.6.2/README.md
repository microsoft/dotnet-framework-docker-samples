dotnetapp-4.6.2 Sample
======================

The dotnetapp-4.6.2 sample demonstrates how you can build and run the dotnetapp sample using the [.NET Framework 4.6.2 Docker image](https://hub.docker.com/r/microsoft/dotnet-framework/).

Script
------

Follow these steps to try out this sample. They assume that you already have [Git](https://git-scm.com/downloads) and [Docker](https://www.docker.com/products/docker) clients installed.

Since the .NET Framework only runs on Windows you must have Docker set to use Windows containers. You can find more information on that here. 

**Preparing your Environment**

1. Git clone this repository or otherwise copy this sample to your machine: `git clone https://github.com/dotnet/dotnet-framework-docker-samples/dotnetapp-4.6.2`
2. Navigate to this sample on your machine at the command prompt or terminal.

**Build and run Docker image**

1. Build the Docker image
   `docker build -t dotnetapp-4.6.2 .`
2. Run the application in the container: 
    `docker run dotnetapp-4.6.2.exe`