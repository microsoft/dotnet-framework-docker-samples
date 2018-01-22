FROM microsoft/dotnet-framework-build:4.7.1 AS build-env
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -o out

FROM microsoft/dotnet-framework:4.7.1
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnetapp.exe"]
