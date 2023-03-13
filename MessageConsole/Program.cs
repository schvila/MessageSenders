// Install the C# / .NET helper library from twilio.com/docs/csharp/install


using System.Text;
using WhatsApp;
using Viber;

WhatsAppTest();
//await ViberTest();
string Decrypt(string pwd)
{
    byte[] b = Convert.FromBase64String(pwd);
    return Encoding.UTF8.GetString(b);

}

 async Task ViberTest()
{
    var viber = new ViberLib();
    var ret = await viber.SendMessageAsync("+420603446641", @"Send by Standa's Viber.Bot");
}
void WhatsAppTest()
{
    string accountSID = Decrypt("QUNlOTkxY2VhNDdjMDkwNWMxZjc1NDZiMDFhZDU3OTU4ZQ==");
    var liborMobil = "+420607046754";
    var token = Decrypt("NjEyNzhjYmRiODFjOWViN2E2YTA4NGYyNDZmODBmZTk=");
    var twilioSendBoxNr = "+14155238886";
    var lib = new WhatsAppLib();
    lib.Init(accountSID, token);
    lib.SendMessage(twilioSendBoxNr, "+420603446641", "WhatsApp api test using Twilio");
    //lib.SendMessage(liborMobil, twilioSendBoxNr, "WhatsApp api test using Twilio");

}