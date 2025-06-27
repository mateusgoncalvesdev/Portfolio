using Portfolio.Data;
using System.Net.Http.Json;

namespace Portfolio.Services;

public class LocationService(HttpClient httpClient) : ILocationService
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<LocationInfo> GetLocationAsync()
    {
        return _httpClient.GetFromJsonAsync<LocationInfo>("data/location.json")!;
    }
}
