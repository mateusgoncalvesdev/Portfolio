using Portfolio.Data;

namespace Portfolio.Services;

public interface IEducationService
{
    Task<List<EducationInfo>> GetEducationAsync();
}
