// See https://aka.ms/new-console-template for more information
using StrategyPattern.Strategies;
using StrategyPattern.Strategies.ConcreteStrategies;

Console.WriteLine("Hello, World!");

var messageSenderContext = new MessageSenderContext(new SmsSender());
messageSenderContext.SendMessage("1234", "Bom dia");

messageSenderContext = new MessageSenderContext(new EmailMessageSender());
messageSenderContext.SendMessage("1234", "Bom dia");

messageSenderContext = new MessageSenderContext(new WhatsAppSender());
messageSenderContext.SendMessage("1234", "Bom dia");

messageSenderContext = new MessageSenderContext(new VoiceMessageSender());
messageSenderContext.SendMessage("1234", "Bom dia");