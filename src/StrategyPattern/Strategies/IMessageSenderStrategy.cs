namespace StrategyPattern.Strategies
{
    public interface IMessageSenderStrategy
    {
        void SendMessage(string userId, string message);
    }
}
