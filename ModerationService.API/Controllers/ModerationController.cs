using Microsoft.AspNetCore.Mvc;

namespace ModerationService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModerationController : ControllerBase
    {
        [HttpPost("analyze")]
        public IActionResult Analyze([FromBody] string message)
        {
            return Ok($"Analyzed message: {message}");
        }
    }
}