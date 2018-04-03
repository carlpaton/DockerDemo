#!/bin/bash
sudo docker pull postgres::9.6-alpine
sudo docker container kill postgres_p6
sudo docker rm postgres_p6
sudo docker run --detach --name=postgres_p6 -p 192.168.231.129:62006:5432  --env="POSTGRES_PASSWORD=postgres" postgres:9.6-alpine
sudo docker start postgres_p6
sudo docker ps --all