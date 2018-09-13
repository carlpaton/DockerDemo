#!/bin/bash
sudo docker pull ubuntu:18.04
sudo docker container kill pgdash-container
sudo docker rm pgdash-container

sudo docker rmi pgdash_image
sudo docker build -t pgdash_image .
sudo docker run -d -p 7001:80 --name pgdash-container pgdash_image

sudo docker start pgdash-container
sudo docker ps --all