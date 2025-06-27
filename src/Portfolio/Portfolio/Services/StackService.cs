using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class StackService(HttpClient httpClient) : IStackService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<List<TechnologyInfo>> GetStackAsync()
    {
        var techNames = await _httpClient.GetFromJsonAsync<List<string>>("data/stack.json") ?? [];
        return techNames.Select(name => new TechnologyInfo { Name = name }).ToList();
    }
}
