Try
{
    docker pull mysql:5.7.24
	docker container kill mysql_codegentool
	docker rm mysql_codegentool
	docker run --detach --name=mysql_codegentool -p 33061:3306  --env="MYSQL_ROOT_PASSWORD=root" mysql:5.7.24
	docker start mysql_codegentool
	docker ps --all	
}
Catch
{
   Write-Host "Exception!! ";
   Write-Host $Error[0].Exception;
}