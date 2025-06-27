using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class EducationService(HttpClient httpClient) : IEducationService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<List<EducationInfo>> GetEducationAsync()
    {
        return _httpClient.GetFromJsonAsync<List<EducationInfo>>("data/education.json")!;
    }
}
