using Portfolio.Data;

namespace Portfolio.Services;

public interface IAboutService
{
    Task<AboutInfo> GetAboutAsync();
}

