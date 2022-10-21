
namespace AboutMe.School.Application.Queries
{
    public interface ISchoolGetAllQuery
    {
        IEnumerable<SchoolQueryResultDto> GetAll();
    }
}
