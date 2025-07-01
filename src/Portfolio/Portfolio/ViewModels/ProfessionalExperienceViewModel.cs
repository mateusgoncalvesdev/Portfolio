namespace Portfolio.ViewModels;

public class ProfessionalExperienceViewModel
{
    public string Company { get; set; } = default!;
    public string Position { get; set; } = default!;
    public string KeyResponsibilities { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Period { get; set; } = default!;
    public string Duration { get; set; } = default!;
}


