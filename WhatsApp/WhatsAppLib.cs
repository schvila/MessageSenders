// Import necessary namespaces
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WhatsApp;

    public class WhatsAppLib
    {
        public void Init(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
        // Send a WhatsApp message
        public MessageResource? SendMessage(string from, string to, string body)
        {
            var message = MessageResource.Create(
                to: new PhoneNumber($"whatsapp:{to}"),
                from: new PhoneNumber($"whatsapp:{from}"),
                body: body);
            return message;
        }
    }
