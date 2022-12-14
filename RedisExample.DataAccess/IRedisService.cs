using StackExchange.Redis;

namespace RedisExample.DataAccess
{
    public interface IRedisService
    {
        Task AddAsync(string key, string value);
        Task<string> GetAsync(string key);
        Task PublishAsync(string channel, string value);
        void Suscribe(string channel, Action<RedisChannel, RedisValue> handler);
    }
}