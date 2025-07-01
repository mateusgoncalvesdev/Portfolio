using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class CourseService(HttpClient httpClient) : ICourseService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<List<Course>> GetCoursesAsync()
    {
        return _httpClient.GetFromJsonAsync<List<Course>>("data/courses.json")!;
    }
}
