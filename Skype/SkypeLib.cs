using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Teams;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Schema.Teams;

namespace Skype;

public class SkypeLib
{
    private ConnectorClient _connector;

    public void Init(string appId, string appPassword)
    {
        _connector = new ConnectorClient(new Uri("https://smba.trafficmanager.net/amer/"), appId, appPassword);
    }

    public async void SendMessage(string conversationId, string text)
    {
        // Send a Skype message
        var message = Microsoft.Bot.Schema.Activity.CreateMessageActivity();
        message.Type = ActivityTypes.Message;
        message.Text = text;
        message.ChannelData = new TeamsChannelData { Channel = new ChannelInfo(conversationId) };
        await _connector.Conversations.SendToConversationAsync((Activity)message);
    }

}
