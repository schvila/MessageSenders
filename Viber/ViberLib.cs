using System.Runtime.CompilerServices;
using Viber.Bot;

namespace Viber;
public class ViberLib
{
    //private _bot = new ViberBot("<auth_token>");

    public async void SendMessageAsync(string recieverId, string message)
    {
        var bot = new ViberBotClient("<auth_token>");
        return await bot.SendTextMessageAsync(recieverId, message);
    }

}
