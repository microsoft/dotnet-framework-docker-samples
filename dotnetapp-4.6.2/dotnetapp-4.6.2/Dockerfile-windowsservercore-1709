FROM microsoft/dotnet-framework:4.6.2 as builder

ENV MSBUILD_DOWNLOAD_URL https://download.microsoft.com/download/E/E/D/EEDF18A8-4AED-4CE0-BEBE-70A83094FC5A/BuildTools_Full.exe

RUN powershell -NoProfile -Command " \
        $ErrorActionPreference = 'Stop'; \
        Invoke-WebRequest %MSBUILD_DOWNLOAD_URL% -OutFile BuildTools_Full.exe; \
        ./BuildTools_Full.exe /Silent /Full /NoRestart | Out-Null; \
        Start-Sleep 2; \
        Remove-Item -Force BuildTools_Full.exe"

RUN setx /M PATH "%PATH%;%ProgramFiles(x86)%\MSBUILD\14.0\bin"

WORKDIR /app
COPY . ./

RUN ["msbuild.exe", "dotnetapp-4.6.2.csproj", "/p:Configuration=Release"]

FROM microsoft/dotnet-framework:4.6.2

WORKDIR /app

COPY --from=builder /app/bin/Release .

ENTRYPOINT ["dotnetapp-4.6.2.exe"]