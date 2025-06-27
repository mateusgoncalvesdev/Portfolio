using Portfolio.Data;

namespace Portfolio.Services;

public interface IProfessionalExperienceService
{
    Task<List<ProfessionalExperience>> GetProfessionalExperiencesAsync();
}
