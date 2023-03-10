using System.Runtime.CompilerServices;
using System.Text;
using Viber.Bot;

namespace Viber;
public class ViberLib
{
    private ViberBotClient _bot;// = new ViberBot("<auth_token>");
    public ViberLib()
    {
        byte[] b = Convert.FromBase64String("NTBiMjg1MTU5ODI3ZTE5YS02NTljMTIyNjg0OTEzMjA0LTY5OWZkM2IwMTdkZTZhYjE=");
        var token = Encoding.UTF8.GetString(b);
        _bot = new ViberBotClient(token);

    }
    public async Task<long> SendMessageAsync(string receiver, string text)
    {
        var message = new BroadcastMessage
        {
            Text = text,
            BroadcastList = new List<string> { receiver }
        };
        return await _bot.SendBroadcastMessageAsync(message);
    }
    public async Task<long> SendMessagesAsync(List<string> receivers, string text)
    {
        var message = new BroadcastMessage
        {
            Text = text,
            BroadcastList = receivers
        };
        return await _bot.SendBroadcastMessageAsync(message);
    }

}
/*
var botClient = new ViberBotClient("YOUR_AUTH_TOKEN_HERE");
var receiver = new Receiver
{
    Id = "01234567890A=",
};
var message = new TextMessage
{
    Text = "Hello, world!",
};
var receivers = new List<Receiver> { receiver };
await1 botClient.SendBroadcastMessageAsync(message, receivers);

 */