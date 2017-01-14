FROM microsoft/iis:10.0.14393.206  
SHELL ["powershell"]

RUN Install-WindowsFeature NET-Framework-45-ASPNET ; \  
    Install-WindowsFeature Web-Asp-Net45

COPY . .  
RUN Remove-WebSite -Name 'Default Web Site'  
RUN New-Website -Name 'aspnetapp' -Port 80 \  
    -PhysicalPath 'c:\' -ApplicationPool '.NET v4.5'
EXPOSE 80

CMD ["ping", "-t", "localhost"] 