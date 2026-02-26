using OpenAI.Chat;

namespace WeatherStation.Interfaces;

public interface ILlmChat
{
    string Chat(ChatMessage[] messages, string? model = null);
    Task<string> ChatAsync(ChatMessage[] messages, string? model = null);
}
