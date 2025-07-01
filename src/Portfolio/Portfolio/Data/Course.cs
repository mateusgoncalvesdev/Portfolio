namespace Portfolio.Data;

public class Course
{
    public string Title { get; set; } = default!;
    public string Provider { get; set; } = default!;
    public int? Hours { get; set; }
    public int? Year { get; set; }
    public DateTime? CompletedAt { get; set; }
}

