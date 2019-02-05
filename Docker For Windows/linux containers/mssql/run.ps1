Try
{
    docker pull microsoft/mssql-server-linux:2017-CU13
	docker container kill microsoftsqlserver_codegentool
	docker rm microsoftsqlserver_codegentool
	docker run --detach --name=microsoftsqlserver_codegentool -p 1433:1433  --env="ACCEPT_EULA=Y" --env="SA_PASSWORD=Password123" microsoft/mssql-server-linux:2017-CU13
	docker start microsoftsqlserver_codegentool
	docker ps --all	
}
Catch
{
   Write-Host "Exception!! ";
   Write-Host $Error[0].Exception;
}