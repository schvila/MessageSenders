// Install the C# / .NET helper library from twilio.com/docs/csharp/install


using WhatsApp;

var accountSID = "ACe991cea47c0905c1f7546b01ad57958e";

var token = "afab8efa3d285871beb4ba5b461c266f";
var twilioSendBoxNr = "+14155238886";
var lib = new WhatsAppLib();
lib.Init(accountSID, token);
//lib.SendMessage("+14155238886", "+420603446641", "WhatsApp api test using Twilio");
lib.SendMessage(twilioSendBoxNr, "+420607046754", "WhatsApp api test using Twilio");

// using Twilio;
// using Twilio.Rest.Api.V2010.Account;
// using Twilio.Types;
//
// class Example
// {
//     static void Main(string[] args)
//     {
//         var accountSid = "ACe991cea47c0905c1f7546b01ad57958e";
//         var authToken = "afab8efa3d285871beb4ba5b461c266f";
//         TwilioClient.Init(accountSid, authToken);
//
//         var messageOptions = new CreateMessageOptions(
//           new PhoneNumber("whatsapp:+420603446641"));
//         messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
//         messageOptions.Body = "Your appointment is coming up on July 21 at 3PM";
//
//
//         var message = MessageResource.Create(messageOptions);
//         Console.WriteLine(message.Body);
//     }
// }