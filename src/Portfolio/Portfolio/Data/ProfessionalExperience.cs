namespace Portfolio.Data;

public class ProfessionalExperience
{
    public int StartYear { get; set; }
    public int? EndYear { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string KeyResponsibilities { get; set; } = string.Empty;
}

