using AboutMe.School.Domain.Model;
using AboutMe.School.Application.Queries;

namespace AboutMe.School.Application.Repositories
{
    public interface ISchoolRepository
    {
        void Add(SchoolEntity School);
        IEnumerable<SchoolQueryResultDto> GetAll();
        SchoolEntity Load(int id);
        void Update(SchoolEntity model);
        SchoolQueryResultDto Get(int id);
    }
}
