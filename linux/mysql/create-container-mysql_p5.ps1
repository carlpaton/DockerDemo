Try
{
	#pull latest mysql image from https://store.docker.com/images/mysql
    docker pull mysql
	
	#kill container mysql_p5 (this stops it)
	docker container kill mysql_p5
	
	#remove container mysql_p5 (this deletes it)
	docker rm mysql_p5
	
	#spin up a new mysql container on port 52005 called mysql_p5
	docker run --detach --name=mysql_p5 -p 127.0.0.1:52005:3306  --env="MYSQL_ROOT_PASSWORD=root" mysql
	
	#start the container
	docker start mysql_p5
	
	#list containers
	docker ps --all	
}
Catch
{
   Write-Host "Exception!! ";
   Write-Host $Error[0].Exception;
}