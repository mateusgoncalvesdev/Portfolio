using Portfolio.Data;

namespace Portfolio.Services;

public interface IPersonalService
{
    Task<PersonalInfo> GetPersonalInfoAsync();
}
