docker run -d `
  --name=wireshark `
  --net=host `
  --cap-add=NET_ADMIN `
  --security-opt seccomp=unconfined `
  -e PUID=1000 `
  -e PGID=1000 `
  -e TZ=Etc/UTC `
  -p 3000:3000 `
  -p 3001:3001 `
  -v /path/to/wireshark/config:/config `
  --restart unless-stopped `
  lscr.io/linuxserver/wireshark:latest