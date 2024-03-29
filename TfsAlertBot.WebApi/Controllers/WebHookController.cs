﻿using System;
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
        public IActionResult Get(string id, [FromBody]Content content)
        {
            TfsAlertBot.Notification.Telegram.Bot.Instance.BotClient.SendTextMessageAsync(id, content.Message.Markdown, ParseMode.Markdown);
            return Ok(id);
        }
    }
}