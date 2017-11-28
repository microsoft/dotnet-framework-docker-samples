.NET Framework Docker Samples
=============================

This repo contains samples that demonstrate various .NET Framework Docker configurations, which you can use as the basis of your own Docker images. These samples depend on the [.NET Framework Docker images](https://hub.docker.com/r/microsoft/dotnet-framework/) on Docker Hub, provided by the .NET Team at Microsoft.

Docker uses [docker/whalesay](https://hub.docker.com/r/docker/whalesay/) as a getting started sample. The .NET Framework Team at Microsoft uses [dotnetbot](https://github.com/dotnet-bot), which is the mascot for .NET open source projects. Got something to say? Both whalesay and dotnetbot are great listeners.

You can pick the sample that best fits the scenario you are interested in. The instructions for each sample describe how to target [Windows](http://aka.ms/windowscontainers).

You need to have the [Docker for Windows client](https://docs.docker.com/docker-for-windows/) client installed to use these samples.

Samples
-------

The following samples show different ways to use .NET Framework images.


# Supported Windows Server 2016 Version 1709 (Fall Creators Update) amd64 tags

- [`4.7.1-windowsservercore-1709`,`4.7.1`,`latest` (*dotnetapp-4.7.1/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-4.7.1/Dockerfile)
- [`3.5-windowsservercore-1709`,`3.5`(*dotnetapp-3.5/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-3.5/Dockerfile)

# Supported Windows Server 2016 amd64 tags

- [`4.7.1-windowsservercore-ltsc2016`, `4.7.1`, `latest` (*dotnetapp-4.7.1/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-4.7.1/Dockerfile)
- [`4.7-windowsservercore-ltsc2016`, `4.7` (*dotnetapp-4.7/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-4.7/Dockerfile)
- [`4.6.2-windowsservercore-ltsc2016`, `4.6.2` (*dotnetapp-4.6.2/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-4.7.1/Dockerfile)
- [`3.5-windowsservercore-ltsc2016`, `3.5` (*dotnetapp-3.5/Dockerfile*)](https://github.com/Microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-3.5/Dockerfile)

>**Note:** .NET Core multi-arch tags, such as 2.0-runtime, have been updated to use nanoserver-1709 images if your host is Windows Server 1709 or higher or Windows 10 Fall Creators Update (Version 1709) or higher. You need Docker 17.10 or later to take advantage of these updated tags.

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

