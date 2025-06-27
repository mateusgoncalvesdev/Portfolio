using Portfolio.Data;

namespace Portfolio.Services;

public interface IProjectService
{
    Task<List<ProjectInfo>> GetProjectsAsync();
}
