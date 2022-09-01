# NET.RedisExample
Example implementation of Redis as a Message Broker. Both as a suscriber and a publisher

In order **to start this app you will need:** 
- **Redis database** running on default port `6379`
- **NET 6 SDK** to run as development or **NET 6 Runtime** to run the build

I worked this repository using a **docker image to work with Redis** on windows and speed up installation:

    docker run --name aspnetrun-redis -d -p 6379:6379 redis

### Message Publisher
The **RedisExample.API** is an NET 6 REST API that publishes messages to the `messages` channel via HTTP POST.

#### `HTTP POST /messages`
Content-Type: `text/json`
Request body:
```
{
	"message": "string"
}
```

### Message Listener
The **RedisExample.MessageListener** is a NET 6 Hosted Console App that suscribes to the `messages` channel and **prints in console all messages it recieves** with the format `channel:message`. 
