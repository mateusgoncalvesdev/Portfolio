using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class ProfessionalExperienceService(HttpClient httpClient) : IProfessionalExperienceService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<List<ProfessionalExperience>> GetProfessionalExperiencesAsync()
    {
        return _httpClient.GetFromJsonAsync<List<ProfessionalExperience>>("data/experiences.json")!;
    }
}
