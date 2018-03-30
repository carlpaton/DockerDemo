#!/bin/bash
sudo docker pull microsoft/dotnet:2.0-sdk
sudo docker container kill dotnet-site
sudo docker rm dotnet-site

sudo docker build -t dotnet-image .
sudo docker run -d -p 192.168.180.129:62082:80 --name dotnet-site dotnet-image

sudo docker start dotnet-site
sudo docker ps --all