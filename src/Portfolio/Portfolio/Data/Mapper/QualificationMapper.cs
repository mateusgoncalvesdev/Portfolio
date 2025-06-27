using Portfolio.ViewModels;

namespace Portfolio.Data.Mapper;

public class QualificationMapper
{
    public static QualificationViewModel MapToViewModel(QualificationInfo qualification)
    {
        if (qualification == null)
        {
            throw new ArgumentNullException(nameof(qualification));
        }

        return new QualificationViewModel
        {
            Description = qualification.Provider == null ?
                $"{qualification.Title}" :
                $"{qualification.Title} ({qualification.Provider}, {qualification.Hours}h - {qualification.Year})"
        };
    }
}
