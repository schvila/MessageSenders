using System.Net.Http.Headers;
using Discord;
using Discord.Net;
using Discord.Webhook;
using Discord.WebSocket;

namespace DiscordSpace;

public class DiscordLib
{
    private DiscordSocketClient _client;

    public async Task Init(string token)
    {
        _client = new DiscordSocketClient();
        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();        
    }

    public async Task SendMessageAsync(ulong userId, string message)
    {
        var user = _client.GetUser(userId);
        var channel = await user.CreateDMChannelAsync();
        if (channel == null)
        {
            throw new InvalidOperationException(
                $"Could not create DM channel with user {user.Username}#{user.Discriminator}.");
        }

        await channel.SendMessageAsync(message);
    }
}
