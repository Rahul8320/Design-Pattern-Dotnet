using System.ClientModel;
using OpenAI;
using OpenAI.Chat;
using WeatherStation.Interfaces;

namespace WeatherStation.Services;

public class LlmChat : ILlmChat
{
    public struct LlmChatModels
    {
        public const string Default = "liquid/lfm2.5-1.2b";
    }

    public string Chat(ChatMessage[] messages, string? model = null)
    {
        var client = GetClient(model ?? LlmChatModels.Default);
        var completion = client.CompleteChat(messages);
        return completion.Value.Content[0].Text;
    }

    public async Task<string> ChatAsync(ChatMessage[] messages, string? model = null)
    {
        var client = GetClient(model ?? LlmChatModels.Default);
        var completion = await client.CompleteChatAsync(messages);
        return completion.Value.Content[0].Text;
    }

    private static ChatClient GetClient(string model)
    {
        var client = new ChatClient(
            model: model,
            credential: new ApiKeyCredential("Not Required"),
            options: new OpenAIClientOptions()
            {
                Endpoint = new Uri("http://127.0.0.1:1234/v1")
            }
        );
        return client;
    }
}
