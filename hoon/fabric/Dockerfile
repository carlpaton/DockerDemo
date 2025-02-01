FROM golang:1.23-alpine
WORKDIR /app

RUN apk add --no-cache git
RUN git clone https://github.com/danielmiessler/fabric.git .
RUN go install github.com/danielmiessler/fabric@latest

ENV GOROOT=/usr/local/go
ENV GOPATH=$HOME/go
ENV PATH=$GOPATH/bin:$GOROOT/bin:$HOME/.local/bin:$PATH

ENTRYPOINT ["fabric"]