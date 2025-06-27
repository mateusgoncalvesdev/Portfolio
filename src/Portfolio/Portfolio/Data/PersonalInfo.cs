namespace Portfolio.Data;

public class PersonalInfo
{
    public NameInfo Name { get; set; } = null!;
    public string Email { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public int BirthYear { get; set; }
    public ProfessionalSummary ProfessionalSummary { get; set; } = null!;
}

