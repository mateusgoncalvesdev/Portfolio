using Portfolio.ViewModels;

namespace Portfolio.Data.Mapper;

public static class ProfessionalExperienceMapper
{
    public static ProfessionalExperienceViewModel MapToViewModel(ProfessionalExperience experience)
    {
        if (experience == null)
        {
            throw new ArgumentNullException(nameof(experience));
        }

        return new ProfessionalExperienceViewModel
        {
            StartYear = experience.StartYear,
            Company = experience.Company,
            Position = experience.Position,
            KeyResponsibilities = experience.KeyResponsibilities,
            Period = experience.EndYear == null
                ? $"{experience.StartYear} - Atualmente"
                : $"{experience.StartYear} - {experience.EndYear}"
        };
    }
}

