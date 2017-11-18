using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace BigBrother
{
    class Program
    {

        private DiscordSocketClient _client;

        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, "MzgxMjU5ODQwMjU4OTY1NTA0.DPJDKw.v3b5tHCdy_9BeC7VKfSbQNxEQBc");
            await _client.StartAsync();
            Console.WriteLine("Logged in and started.");
            await Task.Delay(15000);
            Console.WriteLine("Logging out and stopping.");
            await _client.StopAsync();
            await _client.LogoutAsync();
            await Task.Delay(3000);
        }

    }
}
