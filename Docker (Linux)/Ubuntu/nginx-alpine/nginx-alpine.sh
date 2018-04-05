#!/bin/bash
#sudo docker pull nginx:alpine
sudo docker container kill nginx-site
sudo docker rm nginx-site

sudo docker build -t nginx_image .
sudo docker run -d -p 82:80 --name nginx-site nginx_image

sudo docker start nginx-site
sudo docker ps --all