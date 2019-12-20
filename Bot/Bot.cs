using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot
{
    public class Bot
    {
        List<Chat> _chats = new List<Chat>();
        public TelegramBotClient BotClient;

        private Bot()
        {
            BotClient = new TelegramBotClient(Environment.GetEnvironmentVariable("Token"));
            BotClient.OnMessage += BotClientOnOnMessage;
        }

        private void BotClientOnOnMessage(object sender, MessageEventArgs e)
        {
            if (_chats.FirstOrDefault(c => c.Id == e.Message.Chat.Id) != null)
            {
                return;
            }

            Console.WriteLine(e.Message.Chat.Id);
            Console.WriteLine(e.Message.Text);
            BotClient.SendTextMessageAsync(e.Message.Chat.Id,
                $"привет, вот ссылка {Environment.GetEnvironmentVariable("HOST")}/bot{e.Message.Chat.Id}",
                ParseMode.Markdown);
        }


        private static Bot _instance;

        public static Bot Instance => _instance ??= new Bot();
    }
}