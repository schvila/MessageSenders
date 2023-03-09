using System.Net.Http.Headers;
using Discord;
using Discord.Webhook;

namespace DiscordSpace;

public class DiscordLib
{
    private ConnectorClient _connector;

    public void Init(string appId, string appPassword)
    {
        _connector = new ConnectorClient(new Uri("https://smba.trafficmanager.net/amer/"), appId, appPassword);
    }

    public async SendMessageAsync(string webhookUrl, string message)
    {
        // Set up Discord webhook with your webhook URL
        var webhook = new DiscordWebhookClient(webhookUrl);

        // Send a Discord message
        await webhook.SendMessageAsync(message);

    }


}
