#!/bin/bash
sudo docker pull sonarqube:6.7.4
sudo docker container kill sonarqube
sudo docker rm sonarqube
sudo docker run -d --name sonarqube -p 9000:9000 -p 9092:9092 sonarqube:6.7.4
sudo docker start sonarqube
sudo docker ps --all