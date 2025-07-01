using Portfolio.ViewModels;
using System.Globalization;

namespace Portfolio.Data.Mapper;

public static class ProfessionalExperienceMapper
{
    public static ProfessionalExperienceViewModel MapToViewModel(ProfessionalExperience experience)
    {
        if (experience == null)
            throw new ArgumentNullException(nameof(experience));

        // Datas completas
        var startDate = experience.StartDate;
        var endDate = experience.EndDate ?? DateTime.Now;

        // Exibir período (ex: JAN 2020 - ABR 2021 ou JAN 2020 - AGORA)
        var startText = startDate.ToString("MMM yyyy", new CultureInfo("pt-BR")).ToUpper();
        var endText = experience.EndDate.HasValue
            ? endDate.ToString("MMM yyyy", new CultureInfo("pt-BR")).ToUpper()
            : "HOJE";

        var period = $"{startText} - {endText}";

        // Calcular duração amigável
        var totalMonths = ((endDate.Year - startDate.Year) * 12) + (endDate.Month - startDate.Month);
        var years = totalMonths / 12;
        var months = totalMonths % 12;

        string duration = years switch
        {
            > 0 when months > 0 => $"{years} ano{(years > 1 ? "s" : "")} e {months} mes{(months > 1 ? "es" : "")}",
            > 0 => $"{years} ano{(years > 1 ? "s" : "")}",
            _ => $"{months} mes{(months > 1 ? "es" : "")}"
        };

        return new ProfessionalExperienceViewModel
        {
            Company = experience.Company,
            Position = experience.Position,
            KeyResponsibilities = experience.KeyResponsibilities,
            StartDate = startDate,
            EndDate = experience.EndDate,
            Period = period,
            Duration = duration
        };
    }
}

