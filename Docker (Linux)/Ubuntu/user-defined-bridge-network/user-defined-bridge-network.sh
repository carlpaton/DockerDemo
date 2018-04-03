#!/bin/bash

#With its own bridge
#https://docs.docker.com/network/network-tutorial-standalone/#use-user-defined-bridge-networks

#remove containers first, so the bridge can be removed
sudo docker container kill postgres_nb #network bridge
sudo docker rm postgres_nb
sudo docker container kill dotnet-site_nb
sudo docker rm dotnet-site_nb

#Use user-defined bridge network
sudo docker network rm postgres-net
sudo docker network create --driver bridge postgres-net

#Psql container
sudo docker run --name postgres_nb -e "POSTGRES_PASSWORD=postgres" --network postgres-net -itd postgres:9.6-alpine

#dotnet-site_nb image
sudo docker rmi image_name:dotnet-image_nb
sudo docker build -t dotnet-image_nb .

#dotnet-site_nb container (MVC Core Web API)
sudo docker pull microsoft/dotnet:2.0-sdk
sudo docker run --name dotnet-site_nb -p 192.168.231.129:80:80 --network postgres-net -itd dotnet-image_nb #network bridge 1

#display new containers & bridge
sudo docker ps --all
sudo docker network ls