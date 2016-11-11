# Supported tags and respective `Dockerfile` links

-       [`dotnetapp-4.6.2`, `4.6.2`, `latest` (*dotnetapp-4.6.2/dotnetapp-4.6.2/Dockerfile*)](https://github.com/microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-4.6.2/dotnetapp-4.6.2/Dockerfile)
-       [`dotnetapp-3.5`, `3.5` (*dotnetapp-3.5/dotnetapp-3.5/Dockerfile*)](https://github.com/microsoft/dotnet-framework-docker-samples/blob/dockerhub/dotnetapp-3.5/dotnetapp-3.5/Dockerfile)

For more information about these images and their history, please see [the relevant Dockerfile (`microsoft/dotnet-framework-docker-samples`)](https://github.com/microsoft/dotnet-framework-docker-samples/search?utf8=%E2%9C%93&q=FROM&type=Code). These images are updated via [pull requests to the `microsoft/dotnet-framework-docker` GitHub repo](https://github.com/microsoft/dotnet-framework-docker/pulls?utf8=%E2%9C%93&q=).

[![Downloads from Docker Hub](https://img.shields.io/docker/pulls/microsoft/dotnet-framework-samples.svg)](https://hub.docker.com/r/microsoft/dotnet-framework-samples)
[![Stars on Docker Hub](https://img.shields.io/docker/stars/microsoft/dotnet-framework-samples.svg)](https://hub.docker.com/r/microsoft/dotnet-framework-samples)

# .NET Framework Docker Samples

This repo contains samples that demonstrate various .NET Framework Docker configurations.

You can see the source for these samples at [microsoft/dotnet-framework-samples](https://github.com/microsoft/dotnet-framework-docker-samples/tree/dockerhub) on GitHub.

# What is the .NET Framework?

The [.NET Framework](https://www.microsoft.com/net/framework) is a general purpose development platform maintained by Microsoft. It is the most popular way to build client and server applications for Windows and Windows Server. It is included with Windows, Windows Server and Windows Server Core. It includes server technologies such as ASP.NET Web Forms, ASP.NET MVC and Windows Communication Framework (WCF) applications, which you can run in Docker containers.

.NET has several capabilities that make development easier, including automatic memory management, (runtime) generic types, reflection, asynchrony, concurrency, and native interop. Millions of developers take advantage of these capabilities to efficiently build high-quality web and client applications.

You can use C#, F# and VB to write .NET Framework apps. C# is simple, powerful, type-safe, and object-oriented while retaining the expressiveness and elegance of C-style languages. F# is a multi-paradigm programming language, enabling both functional and object-oriented patterns and practices. VB is a rapid development programming language with the deepest integration between the language and Visual Studio, providing the fastest path to a working app.   

The .NET Framework was first released by Microsoft in 2001. The latest version is [.NET Framework 4.6.2](https://www.microsoft.com/net/framework).

> https://docs.microsoft.com/dotnet/articles/framework/

![dotnet-icon](https://cloud.githubusercontent.com/assets/2608468/19951790/a0458278-a11d-11e6-86e4-660aaa22aa3c.png)

# How to use these Images

## Run a sample .NET Core application within a container

The dotnetapp image is a sample application that depends on the [.NET Framework Runtime image](https://hub.docker.com/r/microsoft/dotnet-framework). You can run it in a container by running the following command.

```console
docker run microsoft/dotnet-framework-samples
```

## Image variants

The `microsoft/dotnet-framework-samples` images come in multiple flavors.

### `microsoft/dotnet-framework-samples:4.6.2`

This image demonstrates the minimal use of the [.NET Framework 4.6.2 image](https://hub.docker.com/r/microsoft/dotnet). It is not intended to be used as the base of another image, but purely used for demonstration purposes.

### `microsoft/dotnet-framework-samples:3.5`

This image demonstrates the minimal use of the [.NET Framework 3.5 image](https://hub.docker.com/r/microsoft/dotnet). It is not intended to be used as the base of another image, but purely used for demonstration purposes.

## Related Repos

See the following related repos for other application types:

- [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
- [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images (for web applications, see microsoft/aspnet).
- [microsoft/dotnet](https://hub.docker.com/r/microsoft/dotnet/) for .NET Core images.
- [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.

# License

.NET Framework samples are licensed as [MIT LICENSE](LICENSE.TXT).

# Supported Docker versions

This image is officially supported on Docker version 1.12.2.

Please see [the Docker installation documentation](https://docs.docker.com/installation/) for details on how to upgrade your Docker daemon.

# User Feedback

## Issues

If you have any problems with or questions about this image, please contact us through a [GitHub issue](https://github.com/microsoft/dotnet-framework-docker-samples/issues).

## Contributing

You are invited to contribute new samples, fixes, or updates, large or small; we are always thrilled to receive pull requests, and do our best to process them as fast as we can.

## Documentation

You can read documentation for .NET Core, including Docker usage in the [.NET Core docs](https://docs.microsoft.com/en-us/dotnet/articles/core/). The docs are [open source on GitHub](https://github.com/dotnet/core-docs). Contributions are welcome!
