sudo docker container kill nginx-site
sudo docker rm nginx-site

sudo docker build -t nginx-image .
sudo docker run -d -p 192.168.231.129:88:80 --name nginx-site nginx-image