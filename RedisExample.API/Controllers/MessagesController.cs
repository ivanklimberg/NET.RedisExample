using Microsoft.AspNetCore.Mvc;
using RedisExample.API.Models;
using RedisExample.DataAccess;

namespace RedisExample.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IRedisService _redisService;

        public MessagesController(IRedisService redisService)
        {
            _redisService = redisService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PostMessagesModel model)
        {
            await _redisService.PublishAsync("messages", model.Message);

            return Ok(new
            {
                Success = true
            });
        }
    }
}
