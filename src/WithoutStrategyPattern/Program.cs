// See https://aka.ms/new-console-template for more information
using WithoutStrategyPattern.Services;

Console.WriteLine("Hello, World!");

var messageSender = new MessageSender();
messageSender.SendMessage("1234", "Bom dia","Sms");

messageSender.SendMessage("1234", "Bom dia","Email");

messageSender.SendMessage("1234", "Bom dia","WhatsApp");

messageSender.SendMessage("1234", "Bom dia", "WhatsApp");