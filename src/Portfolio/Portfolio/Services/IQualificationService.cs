using Portfolio.Data;

namespace Portfolio.Services;

public interface IQualificationService
{
    Task<List<QualificationInfo>> GetQualificationsAsync();
}
