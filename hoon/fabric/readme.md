Build and tag the image

```
docker build -t the-fabric .
```

Run the image in interactive mode

```
docker run --rm -it `
-v /home/networkchuck/.config/fabric:/root/.config/fabric/ `
the-fabric fabric 
```

How to find pattern usage run the command above and add `-h`

Example pattern

```
echo ""
```