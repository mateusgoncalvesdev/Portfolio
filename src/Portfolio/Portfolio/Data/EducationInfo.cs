namespace Portfolio.Data;

public class EducationInfo
{
    public string Course { get; set; } = string.Empty;
    public string Institution { get; set; } = string.Empty;
    public int StartYear { get; set; }
    public int? EndYear { get; set; }
    public string Status { get; set; } = string.Empty;
}

