# Docker (Linux)
Look in '\DockerDemo\Docker (Linux)\[OS NAME]'

- Each folder has a 'vm setup.txt' file with instructions
- Each container then listed below has a '.txt' help file and a bash script
- TODO : Complete Apline & RancherOS

## postgres

### Bash Script
~ \DockerDemo\Docker (Linux)\Ubuntu\postgres.sh 

### Get VM IP
Note the IP on the Linux VM with `ip addr show` 

~ Example: 192.168.231.129

### Create bash script

- sudo nano postgres.sh ~ add content from '\DockerDemo\Docker (Linux)\Ubuntu\postgres.sh' ~ update the -p switch with your IPr 
- sudo chmod +x postgres.sh ~ This marks its as mark executable
- sudo ./postgres.sh ~ runs the script

This will then create your container, you can then connect to it from DBeaver / pgAdmin

## mysql
~ \DockerDemo\Docker (Linux)\Ubuntu\mysql.sh

## mssql-server-linux
~ \DockerDemo\Docker (Linux)\Ubuntu\mssql-server-linux.sh

# Docker For Windows
Look in '\DockerDemo\Docker For Windows'

## Prerequisite download
- Download Docker for windows CE from https://www.docker.com/docker-windows
- Run the install, windows will re-boot a few times and install some updates.
- The linux VM lives here, C:\Users\Public\Documents\Hyper-V\Virtual hard disks\  ~ try not to upset it.

## PowerShell
Run these commands to allow the ps1 scripts to execute

Get-ExecutionPolicy
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

### Folder locations
CD quickly to the location you clone the repository too, I saved this as 'C:\Users\Carl\CD-CodeLocation.ps1' (Im lazy :D)
Set-Location -Path C:\Dev-Code-School\DockerDemo

### Windows Containers
- NB - Switch docker for windows to run as 'WINDOWS CONTAINERS' from the system tray.
- Run \DockerDemo\Docker For Windows\windows containers\aspnet\build-container-aspnet.ps1
- The initial image pull WILL TAKE SOME TIME, ignore the initial container kill/rm fails on 'aspnet-site'
- Open the given IP in your browser. The WEB API helpfile is shown from the projects 'HelpPage' area
- Source code for the sample API is here ~ \DockerDemo\Sample API Code\WebApi\

- Run \DockerDemo\Docker For Windows\windows containers\iis\build-container-iissite.ps1
- The initial image pull will take some time, ignore the initial container kill/rm fails on 'iis-site'
- Open the given IP in your browser on Port 80, default IIS landing screen is shown
- Open the given IP in your browser on Port 81, content\index.htm is shown

### Linux Containers
- NB - Switch docker for windows to run as 'LINUX CONTAINERS' from the system tray.
- Run \DockerDemo\Docker For Windows\linux containers\mysql\create-container-mysql_p5.ps1
- Ignore the initial container kill/rm fails on 'mysql_p5'
- Connect to the mysql_p5 container instance on 127.0.0.1:62005
- There are some fly scripts at \DockerDemo\linux\mysql\flyway ~ These can be added to the powershell script or run manually.

- Run C:\Dev-Code-School\DockerDemo\Docker For Windows\linux containers\postgresql\create-container-postgres_p6.ps1
- Ignore the initial container kill/rm fails on 'postgres_p6'
- Connect to the postgres_p6 container instance on 127.0.0.1:62006

# Other Docker Commands
- docker version                 ~ display version
- docker run hello-world         ~ run hello-world tester
- docker ps --all                ~ List containers
- docker network ls              ~ List Docker’s networks
- docker network inspect [NETWORK NAME]
- docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" [CONTAINER NAME] ~ shows its IP to get around the WinNAT plow
- docker logs [CONTAINER NAME]
- docker images                  ~ shows all the images on your disk.
- docker container inspect [CONTAINER NAME]

# Linux Commands
- ll ~ list files (same as DIR)
- la ~ list files horizontally
- rm -r mydir
- mkdir mydir
- sudo shutdown

# Zip
- sudo apt-get update
- sudo apt-get install zip unzip
~ sudo unzip content.zip

# References

## PuTTY
https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html
https://community.nxp.com/thread/220596

## VMware Workstation Player 
https://my.vmware.com/en/web/vmware/free#desktop_end_user_computing/vmware_workstation_player/14_0

## Docker
https://docs.docker.com/engine/reference/commandline/logs/
https://docs.docker.com/config/pruning/

### Linux Operating Systems
https://askubuntu.com/questions/223691/how-do-i-create-a-script-file-for-terminal-commands/223698

#### Ubuntu
https://www.ubuntu.com/download/desktop
https://askubuntu.com/questions/938700/how-do-i-install-docker-on-ubuntu-16-04-lts
https://docs.docker.com/install/linux/docker-ce/ubuntu/

#### Alpine
https://wiki.alpinelinux.org/wiki/Docker
https://wiki.alpinelinux.org/wiki/Alpine_Linux_package_management

#### RancherOS
https://rancher.com/rancher-os/
https://github.com/rancher/os/releases/tag/v1.3.0
https://rancher.com/docs/os/v1.2/en/quick-start-guide/

### Docker Containers

#### mssql-server-linux
https://store.docker.com/images/mssql-server-windows-express/
https://hub.docker.com/r/microsoft/mssql-server-linux/
https://docs.microsoft.com/en-gb/sql/linux/quickstart-install-connect-docker
https://docs.docker.com/engine/reference/commandline/logs/
https://github.com/Microsoft/mssql-docker/issues/195

#### mysql
https://store.docker.com/images/mysql

#### postgres
https://store.docker.com/images/postgres

#### microsoft/dotnet
https://hub.docker.com/r/microsoft/aspnetcore/
https://store.docker.com/images/dotnet
https://docs.docker.com/engine/examples/dotnetcore/#create-a-dockerfile-for-an-aspnet-core-application
