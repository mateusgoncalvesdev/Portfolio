using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class PersonalService(HttpClient httpClient) : IPersonalService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<PersonalInfo> GetPersonalInfoAsync()
    {
        return _httpClient.GetFromJsonAsync<PersonalInfo>("data/personal.json?v=2")!;
    }
}
