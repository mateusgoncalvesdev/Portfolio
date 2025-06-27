using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class ProjectService(HttpClient httpClient) : IProjectService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<List<ProjectInfo>> GetProjectsAsync()
    {
        return _httpClient.GetFromJsonAsync<List<ProjectInfo>>("data/projects.json")!;
    }
}
