using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStrategyPattern.Services
{
    public class MessageSender
    {
        public void SendMessage(string userId, string message, string channel)
        {
            if (channel == "Email")
                SendEmailMessage(userId, message);
            else if (channel == "Sms")
                SensSmsMessage(userId, message);
            else if (channel == "VoiceMessage")
                SendVoiceMessage(userId, message);
            else if (channel == "WhatsApp")
                SendWhatsAppMessage(userId, message);
        }

        private static void SendEmailMessage(string userId, string message)
        {
            Console.WriteLine($"Enviando para User: {userId} - via Email: {message}");
        }

        private static void SendVoiceMessage(string userId, string message)
        {
            Console.WriteLine($"Enviando para User: {userId} - via Mensagem de Voz: {message}");
        }

        private static void SensSmsMessage(string userId, string message)
        {
            Console.WriteLine($"Enviando para User: {userId} - via Sms: {message}");
        }

        private static void SendWhatsAppMessage(string userId, string message)
        {
            Console.WriteLine($"Enviando para User: {userId} - via WhatsApp: {message}");
        }
    }
}
