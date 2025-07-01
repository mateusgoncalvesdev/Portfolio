using Portfolio.Data;

namespace Portfolio.Services;

public interface ICourseService
{
    Task<List<Course>> GetCoursesAsync();
}
