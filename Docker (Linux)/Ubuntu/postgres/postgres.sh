#!/bin/bash
#sudo docker pull postgres::9.6-alpine
sudo docker container kill postgres-p6
sudo docker rm postgres-p6
sudo docker run --detach --name=postgres-p6 -p 62006:5432  --env="POSTGRES_PASSWORD=postgres" postgres:9.6-alpine
sudo docker start postgres-p6
sudo docker ps --all