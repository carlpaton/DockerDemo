#!/bin/bash
#sudo docker pull mysql:5.7.21
sudo docker container kill mysql-p7
sudo docker rm mysql-p7
sudo docker run --detach --name=mysql-p7 -p 62007:3306  --env="MYSQL_ROOT_PASSWORD=root" mysql:5.7.21
sudo docker start mysql-p7
sudo docker ps --all