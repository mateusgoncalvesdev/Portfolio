namespace Portfolio.ViewModels;

public class ProfessionalExperienceViewModel
{
    public string Company { get; set; } = default!;
    public string Position { get; set; } = default!;
    public List<string> MainActivities { get; set; } = [];
    public List<string> Achievements { get; set; } = [];
    public List<string> TechnologiesAndMethods { get; set; } = [];
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Period { get; set; } = default!;
    public string Duration { get; set; } = default!;
}


