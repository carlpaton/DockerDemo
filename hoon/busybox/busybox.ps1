# this would not see the mount, even when granted manually in docker desktop under setting file sharing
#docker run -it --rm `
#--mount type=bind,src=/data1,dst=/container-data1 `
#busybox

# create the container with `docker compose up
# connect to it like this
docker start -ai busybox-my-busybox-1