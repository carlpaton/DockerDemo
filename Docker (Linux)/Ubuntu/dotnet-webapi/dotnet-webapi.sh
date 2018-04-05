#!/bin/bash
#sudo docker pull microsoft/dotnet:2.0-sdk
sudo docker container kill dotnet-webapi
sudo docker rm dotnet-webapi

sudo docker rmi image_name:dotnet_image_webapi
sudo docker build -t dotnet_image_webapi .
sudo docker run -d -p 81:80 --name dotnet-webapi dotnet_image_webapi

sudo docker start dotnet-webapi
sudo docker ps --all