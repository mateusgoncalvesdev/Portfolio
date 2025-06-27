using Portfolio.Data;

namespace Portfolio.Services;

public interface IStackService
{
    Task<List<TechnologyInfo>> GetStackAsync();
}
