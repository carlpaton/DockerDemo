Try
{
	#pull latest postgres image from https://store.docker.com/images/postgres
    docker pull postgres
	
	#kill container postgres_p6 (this stops it)
	docker container kill postgres_p6
	
	#remove container postgres_p6 (this deletes it)
	docker rm postgres_p6
	
	#spin up a new postgres container on port 62006 called postgres_p6
	docker run --detach --name=postgres_p6 -p 127.0.0.1:62006:5432  --env="POSTGRES_PASSWORD=postgres" postgres
	
	#start the container
	docker start postgres_p6
	
	#list containers
	docker ps --all	
}
Catch
{
   Write-Host "Exception!! ";
   Write-Host $Error[0].Exception;
}