namespace Portfolio.Data;

public class ProfessionalExperience
{
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public List<string> MainActivities { get; set; } = [];
    public List<string> Achievements { get; set; } = [];
    public List<string> TechnologiesAndMethods { get; set; } = [];
}

