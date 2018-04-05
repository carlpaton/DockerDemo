#!/bin/bash
#sudo docker pull microsoft/mssql-server-linux:2017-CU5
sudo docker container kill mssql-p5
sudo docker rm mssql-p5
sudo docker run --name=mssql-p5 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Password123' -e 'MSSQL_PID=Express' -p 62005:1433 -d microsoft/mssql-server-linux:2017-CU5
sudo docker start mssql-p5
sudo docker ps --all