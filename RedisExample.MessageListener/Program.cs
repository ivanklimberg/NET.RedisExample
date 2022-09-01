using RedisExample.DataAccess;
using RedisExample.MessageListener;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

var multiplexer = ConnectionMultiplexer.Connect("localhost:6379");
builder.Services.AddSingleton<IConnectionMultiplexer>(multiplexer);

builder.Services.AddTransient<IRedisService, RedisService>();

builder.Services.AddHostedService<MessageListenerHostedService>();

var app = builder.Build();

app.Run();