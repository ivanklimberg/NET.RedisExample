using RedisExample.DataAccess;

namespace RedisExample.MessageListener
{
    public class MessageListenerHostedService : IHostedService
    {
        private readonly IRedisService _redisService;

        public MessageListenerHostedService(IRedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _redisService.Suscribe("messages", (channel, value) =>
            {
                Console.WriteLine(channel + ":" + value);
            });
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            
        }
    }
}
