FROM microsoft/dotnet-framework-build:3.5 AS build-env
WORKDIR /app

COPY *.csproj .
# Uncomment next two lines if you need/add packages.config
#COPY packages.config .
#RUN msbuild.exe /t:restore

COPY . .
RUN msbuild.exe /t:Build /p:Configuration=Release /p:OutputPath=out

FROM microsoft/dotnet-framework:3.5
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnetapp.exe"]