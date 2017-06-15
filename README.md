.NET Framework Docker Samples
=============================

This repo contains samples that demonstrate various .NET Framework Docker configurations, which you can use as the basis of your own Docker images. These samples depend on the [.NET Framework Docker images](https://hub.docker.com/r/microsoft/dotnet-framework/) on Docker Hub, provided by the .NET Team at Microsoft.

Docker uses [docker/whalesay](https://hub.docker.com/r/docker/whalesay/) as a getting started sample. The .NET Team at Microsoft uses [dotnetbot](https://github.com/dotnet-bot), which is the mascot for .NET open source projects. Got something to say? Both whalesay and dotnetbot are great listeners.

You can pick the sample that best fits the scenario you are interested in. The instructions for each sample describe how to target [Windows Containers](http://aka.ms/windowscontainers).

Requirements
-------

You need to have the [Docker for Windows](https://docs.docker.com/docker-for-windows/) client installed to use these samples.

Samples
-------

The following samples show different ways to use .NET images.

### .NET Framework 4.7

- [dotnetapp-4.7](dotnetapp-4.7) - This sample demonstrates how to build a Docker image for a .NET Framework 4.7 application. It can also be used with applications built for earlier .NET 4.x versions of the .NET Framework.


### .NET Framework 4.6.2

- [dotnetapp-4.6.2](dotnetapp-4.6.2) - This sample demonstrates how to build a Docker image for a .NET Framework 4.6.2 application. It can also be used with applications built for earlier .NET 4.x versions of the .NET Framework.

### .NET Framework 3.5

- [dotnetapp-3.5](dotnetapp-3.5) - This sample demonstrates how to build a Docker image for a .NET Framework 3.5 application. It can also be used with applications built for earlier versions of the .NET Framework.

### ASP.NET Web Forms using .NET Framework 4.6.2

- [aspnetapp](aspnetapp) - This sample demonstrates how to build a Docker image for an ASP.NET Web Forms application that uses .NET Framework 4.6.2.

Related Repositories
--------------------

See the following related Docker Hub repos:

- [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images (for web applications, see microsoft/aspnet).
- [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
- [microsoft/dotnet](https://hub.docker.com/r/microsoft/dotnet/) for .NET Core images.
- [microsoft/dotnet-samples](https://hub.docker.com/r/microsoft/dotnet-samples/) for .NET Core sample images.
- [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.

See the following related  GitHub repos:

- [dotnet/dotnet-docker-samples](https://github.com/dotnet/dotnet-docker-samples/) for .NET Core samples.
