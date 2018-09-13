FROM ubuntu:18.04
RUN apt-get update
RUN apt-get -yq install wget
RUN wget https://packages.rapidloop.com/downloads/pgdash-server_1.18_amd64.deb
RUN dpkg -i pgdash-server_1.18_amd64.deb
COPY pgdash.cfg /etc/pgdash
COPY TTDFF-4GRR0-NLVB4-93CTS-TJFTC.lic /etc/pgdash
ENTRYPOINT ["/usr/sbin/pgdashd"]