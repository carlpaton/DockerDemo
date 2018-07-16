#!/bin/bash


#WEB HOSTING
#dotnet
sudo docker pull microsoft/dotnet:2.0-sdk
sudo docker pull microsoft/aspnetcore:2.0
#nginx-alpine
sudo docker pull nginx:alpine
#dotnet-samples-aspnetapp
sudo docker pull microsoft/dotnet-samples:aspnetapp 


#UTILS
#flyway-docker
sudo docker pull boxfuse/flyway:5.1
#postgrest api
sudo docker pull postgrest/postgrest:v0.5.0.0


#DATABASE
#postgres
sudo docker pull postgres:9.6-alpine
#mssql-server-linux
sudo docker pull microsoft/mssql-server-linux:2017-CU5
#mysql
sudo docker pull mysql:5.7.21


#CUSTOM
sudo docker pull carlpaton/fizzbuzz:v1.1.0