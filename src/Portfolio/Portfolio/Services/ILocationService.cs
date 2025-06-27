using Portfolio.Data;

namespace Portfolio.Services;

public interface ILocationService
{
    Task<LocationInfo> GetLocationAsync();
}
