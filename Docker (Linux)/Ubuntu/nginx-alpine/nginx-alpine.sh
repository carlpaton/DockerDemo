#!/bin/bash
sudo docker pull nginx:alpine
sudo docker container kill nginx-site
sudo docker rm nginx-site

sudo docker build -t nginx-image .
sudo docker run -d -p 192.168.180.129:62080:80 --name nginx-site nginx-image

sudo docker start nginx-site
sudo docker ps --all