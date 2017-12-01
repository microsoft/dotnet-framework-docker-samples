FROM microsoft/dotnet-framework-build:4.7.1 as builder
WORKDIR /app
COPY . ./
RUN ["msbuild.exe", "dotnetapp-4.7.1.csproj", "/p:Configuration=Release"]

FROM microsoft/dotnet-framework:4.7.1
WORKDIR /app
COPY --from=builder /app/bin/Release .

ENTRYPOINT ["dotnetapp-4.7.1.exe"]