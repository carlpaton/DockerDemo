#Uncomment the below if you wish to make all errors terminating
#$ErrorActionPreference = "Stop";

Try
{
	#pull latest 'ASPNET Docker Image' from https://store.docker.com/images/aspnet
	docker pull microsoft/aspnet

	#kill container 'aspnet-site' (this stops it)
	docker container kill aspnet-site

	#remove container 'aspnet-site' (this deletes it)
	docker rm aspnet-site

	#build image
	docker build -t aspnet-image --build-arg site_root=/ .

	#spin up a new iis container on port 80 as 'test-site'
	docker run -d -p 80:80 --name aspnet-site aspnet-image

	#start the container
	docker start aspnet-site

	#list containers
	docker ps --all

	#With the current release, you can't use http://localhost to browse your site from the container host. 
	#This is because of a known behavior in WinNAT, and will be resolved in future. Until that is addressed, you need to use the IP address of the container.
	#Once the container starts, you'll need to finds its IP address so that you can connect to your running container from a browser. You use the docker inspect command to do that: 
    Write-Host "Browse to this IP on your browser: ";	
	docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" aspnet-site	
}
Catch
{
   Write-Host "You farming bru";
   Write-Host $Error[0].Exception;
}