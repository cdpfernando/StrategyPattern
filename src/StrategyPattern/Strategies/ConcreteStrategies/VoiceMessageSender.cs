using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies.ConcreteStrategies
{
    public class VoiceMessageSender : IMessageSenderStrategy
    {
        public void SendMessage(string userId, string message)
        {
            Console.WriteLine($"Enviando para User: {userId} - via Mensagem de voz: {message}");
        }
    }
}
