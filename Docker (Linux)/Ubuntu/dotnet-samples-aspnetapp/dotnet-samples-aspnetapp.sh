#samples
#!/bin/bash
sudo docker container kill dotnet-site2
sudo docker rm dotnet-site2
sudo docker pull microsoft/dotnet-samples:aspnetapp 
sudo docker run -d -p 192.168.180.129:62081:80 --name dotnet-site2 microsoft/dotnet-samples:aspnetapp 
sudo docker start dotnet-site2
sudo docker ps --all

#inspect
#sudo docker inspect -f "{{ .NetworkSettings.IPAddress }}" dotnet-site2
#sudo docker exec dotnet-site2 ipconfig

#connect to the container
#sudo docker exec -it dotnet-site2 bash