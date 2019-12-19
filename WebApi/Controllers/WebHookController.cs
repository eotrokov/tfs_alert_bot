using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Telegram.Bot.Types.Enums;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        
        private readonly ILogger<WebHookController> _logger;

        public WebHookController(ILogger<WebHookController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{id}")]
        public IActionResult Get(string id, [FromBody]Data data)
        {
            Bot.Bot.Instance.BotClient.SendTextMessageAsync(id, data.Message.Markdown, ParseMode.Markdown);
            return Ok(id);
        }
    }
}