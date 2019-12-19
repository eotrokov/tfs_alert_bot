using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace Bot
{
    public class Bot
    {
        public TelegramBotClient BotClient;

        private Bot()
        {
            Environment.SetEnvironmentVariable("Token", "1014817526:AAGC3EarTPI0d2HL8UTQ9mCnh2krzEf3UJg");
            BotClient = new TelegramBotClient(Environment.GetEnvironmentVariable("Token"));
            BotClient.OnMessage += BotClientOnOnMessage;
        }

        private void BotClientOnOnMessage(object sender, MessageEventArgs e)
        {
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