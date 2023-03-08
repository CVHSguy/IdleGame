using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlayer")]
        public IEnumerable<Player> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Player
            {
                PlayerID = Random.Shared.Next(),
                Points = Random.Shared.Next(),
            })
            .ToArray();
        }
    }
}