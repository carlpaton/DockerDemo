# Docker (Linux)
Look in '\DockerDemo\Docker (Linux)'

ubuntu postgres.txt (Commands functional)
alpine postgres.txt (Still needs some google'neering

---------------------------------------------------------------------------------

# Docker For Windows
Look in '\DockerDemo\Docker For Windows'

# PowerShell
Run these commands to allow the ps1 scripts to execute

Get-ExecutionPolicy
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

# Folder locations
Examples assume the repository was cloned to 'C:\Dev-Code-School\DockerDemo'
CD quickly to the location you clone the repository too, I saved this as 'C:\Users\Carl\CD-CodeLocation.ps1' (Im lazy :D)
Set-Location -Path C:\Dev-Code-School\DockerDemo

# Prerequisite download
Download Docker for windows CE from https://www.docker.com/docker-windows
Run the install, windows will re-boot a few times and install some updates.
The linux VM lives here, C:\Users\Public\Documents\Hyper-V\Virtual hard disks\  ~ try not to upset it.

# Windows scripts
NB - Switch docker for windows to run as 'WINDOWS CONTAINERS' from the system tray.
Run C:\Dev-Code-School\DockerDemo\windows\aspnet\build-container-aspnet.ps1
The initial image pull WILL TAKE SOME TIME, ignore the initial container kill/rm fails on 'aspnet-site'
Open the given IP in your browser. The WEB API helpfile is shown from the projects 'HelpPage' area
Source code for the sample API is here ~ C:\Dev-Code-School\DockerDemo\Sample API Code\WebApi\

Run C:\Dev-Code-School\DockerDemo\windows\iis\build-container-iissite.ps1
The initial image pull will take some time, ignore the initial container kill/rm fails on 'iis-site'
Open the given IP in your browser on Port 80, default IIS landing screen is shown
Open the given IP in your browser on Port 81, content\index.htm is shown

# Linux scripts
NB - Switch docker for windows to run as 'LINUX CONTAINERS' from the system tray.
Run C:\Dev-Code-School\DockerDemo\linux\mysql\create-container-mysql_p5.ps1
Ignore the initial container kill/rm fails on 'mysql_p5'
Connect to the mysql_p5 container instance on 127.0.0.1:52005
There are some fly scripts at C:\Dev-Code-School\DockerDemo\linux\mysql\flyway ~ These can be added to the powershell script or run manually.

Run C:\Dev-Code-School\DockerDemo\linux\postgresql\create-container-postgres_p6.ps1
Ignore the initial container kill/rm fails on 'postgres_p6'
Connect to the postgres_p6 container instance on 127.0.0.1:62006

# TODO
https://store.docker.com/images/mssql-server-windows-express

# Other Docker Commands
docker version                 ~ display version
docker run hello-world         ~ run hello-world tester
docker ps 	                   ~ List containers
docker ps -aq -f status=exited
docker ps --all
docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" [CONTAINER NAME] ~ shows its IP to get around the WinNAT plow