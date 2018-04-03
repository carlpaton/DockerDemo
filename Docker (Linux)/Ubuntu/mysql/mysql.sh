#!/bin/bash
sudo docker pull mysql:5.7.21
sudo docker container kill mysql_p7
sudo docker rm mysql_p7
sudo docker run --detach --name=mysql_p7 -p 192.168.231.129:62007:3306  --env="MYSQL_ROOT_PASSWORD=root" mysql:5.7.21
sudo docker start mysql_p7
sudo docker ps --all