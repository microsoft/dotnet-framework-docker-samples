FROM microsoft/dotnet-framework-build:3.5 as builder
WORKDIR /app
COPY . ./
RUN ["msbuild.exe", "dotnetapp-3.5.csproj", "/p:Configuration=Release"]

FROM microsoft/dotnet-framework:3.5
WORKDIR /app
COPY --from=builder /app/bin/Release .

ENTRYPOINT ["dotnetapp-3.5.exe"]
