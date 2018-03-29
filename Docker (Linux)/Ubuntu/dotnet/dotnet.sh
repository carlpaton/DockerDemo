#!/bin/bash
sudo docker pull microsoft/dotnet
sudo docker container kill aspnetcore_sample
sudo docker rm aspnetcore_sample
docker run --rm -p 8000:80 --name aspnetcore_sample microsoft/dotnet-samples:aspnetapp
sudo docker start aspnetcore_sample
sudo docker ps --all