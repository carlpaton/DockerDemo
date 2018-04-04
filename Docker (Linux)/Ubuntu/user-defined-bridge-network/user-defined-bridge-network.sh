#!/bin/bash

#links
#https://docs.docker.com/network/network-tutorial-standalone/#use-user-defined-bridge-networks
#https://app.pluralsight.com/player?course=docker-deep-dive-update&author=nigel-poulton&name=97b58d47-d08f-4894-88c7-4a7ec4c746ea&clip=1&mode=live

#pull
#sudo docker pull microsoft/dotnet:2.0-sdk

#remove containers first, so the bridge can be removed
#_gg tells me its intended to be used on the 'golden-gate' bridge
sudo docker container kill postgres_gg
sudo docker rm postgres_gg
sudo docker container kill dotnet_webapi_gg
sudo docker rm dotnet_webapi_gg

#Use user-defined bridge network called 'golden-gate' ~ lol with Nigel Poulton :D
sudo docker network rm golden-gate 
sudo docker network create --driver bridge golden-gate #'--driver bridge' is the default so can be omitted ~ can be 'overlay' to be scoped to the swarm

#postgres container
#adding the port map '-p 5432:5432' gives access to the image (on 5432) even when its on our 'golden-gate' bridge
sudo docker run --name postgres_gg -e "POSTGRES_PASSWORD=postgres" --network golden-gate -itd postgres:9.6-alpine

#dotnet image for our web api project
sudo docker rmi image_name:dotnet_image_webapi
sudo docker build -t dotnet_image_webapi .

#dotnet_webapi_gg container (MVC Core Web API)
sudo docker run --name dotnet_webapi_gg -p 192.168.231.129:80:80 --network golden-gate -itd dotnet_image_webapi

#display new containers & bridge
sudo docker ps --all
sudo docker network ls

#option to add the container to user defined network after spinning it up
#sudo docker network connect golden-gate [CONTAINER NAME]
#sudo docker network connect bridge [CONTAINER NAME]

#create EXEC session to container
#sudo docker exec -it 279 sh (where 279 is the start of the container ID)
#then you can PING [CONTAINER NAME] (note the container you ping needs to be on the same bridge, example golden-gate)
#CRTL C ~ quit ping
#CTRL PQ ~ quit EXEC session

#inspect network
#sudo docker network inspect [BRIDGE NAME]