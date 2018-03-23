#Uncomment the below if you wish to make all errors terminating
#$ErrorActionPreference = "Stop";

Try
{
	#pull latest 'IIS Docker Image' from https://store.docker.com/images/iis
	docker pull microsoft/iis

	#kill container 'iis-site' (this stops it)
	docker container kill iis-site

	#remove container 'iis-site' (this deletes it)
	docker rm iis-site

	#build image
	docker build -t iis-image .

	#spin up a new iis container on port 81 called 'iis-site'
	docker run -d -p 81:81 --name iis-site iis-image

	#start the container
	docker start iis-site

	#list containers
	docker ps --all

	#With the current release, you can't use http://localhost to browse your site from the container host. 
	#This is because of a known behavior in WinNAT, and will be resolved in future. Until that is addressed, you need to use the IP address of the container.
	#Once the container starts, you'll need to finds its IP address so that you can connect to your running container from a browser. You use the docker inspect command to do that: 
    Write-Host "Browse to this IP on your browser: ";		
	docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" iis-site	
}
Catch
{
   Write-Host "You farming bru";
   Write-Host $Error[0].Exception;
}