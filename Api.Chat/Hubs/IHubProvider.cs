using Api.Chat.Entities;

namespace Api.Chat.Hubs
{
    public interface IHubProvider
    {
        Task ReceivedMessage(Message message);
    }
}
