namespace StrategyPattern.Strategies
{
    public  class MessageSenderContext
    {
        public MessageSenderContext(IMessageSenderStrategy messageSender)
        {
            _messageSender = messageSender;
        }

        private readonly IMessageSenderStrategy _messageSender;

        public void SendMessage(string userId, string message)
        {
            _messageSender.SendMessage(userId, message);
        }
    }
}
