using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class AboutService(HttpClient httpClient) : IAboutService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<AboutInfo> GetAboutAsync()
    {
        return _httpClient.GetFromJsonAsync<AboutInfo>("data/about.json")!;
    }
}

