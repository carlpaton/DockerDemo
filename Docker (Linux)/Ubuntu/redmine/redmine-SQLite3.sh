#!/bin/bash
#https://store.docker.com/images/redmine

sudo docker pull redmine:3.4.6
sudo docker container kill redmine346-sqlite
sudo docker rm redmine346-sqlite
sudo docker run -d -p 3000:3000 --name redmine346-sqlite redmine:3.4.6
#sudo docker ps --all


sudo docker pull redmine:2.6.6
sudo docker container kill redmine260-sqlite
sudo docker rm redmine260-sqlite
sudo docker run -d -p 3001:3000 --name redmine260-sqlite redmine:2.6.6
sudo docker ps --all