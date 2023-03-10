// Install the C# / .NET helper library from twilio.com/docs/csharp/install


using System.Text;
using WhatsApp;

var security = "NjEyNzhjYmRiODFjOWViN2E2YTA4NGYyNDZmODBmZTk=";
byte[] b = Convert.FromBase64String(security);
string accountSID = Decrypt("QUNlOTkxY2VhNDdjMDkwNWMxZjc1NDZiMDFhZDU3OTU4ZQ==");
var liborMobil = "+420607046754";
var token = Decrypt("NjEyNzhjYmRiODFjOWViN2E2YTA4NGYyNDZmODBmZTk=");
var twilioSendBoxNr = "+14155238886";
var lib = new WhatsAppLib();
lib.Init(accountSID, token);
lib.SendMessage("+14155238886", liborMobil, "WhatsApp api test using Twilio");
string Decrypt(string pwd)
{
    byte[] b = Convert.FromBase64String(pwd);
    return Encoding.UTF8.GetString(b);

}