using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class QualificationService(HttpClient httpClient) : IQualificationService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<List<QualificationInfo>> GetQualificationsAsync()
    {
        return _httpClient.GetFromJsonAsync<List<QualificationInfo>>("data/qualifications.json")!;
    }
}
