using AboutMe.School.Application.Repositories;

namespace AboutMe.School.Application.Queries.Implementation
{
    public class SchoolGetAllQuery : ISchoolGetAllQuery
    {
        private readonly ISchoolRepository _repository;
        public SchoolGetAllQuery(ISchoolRepository repository)
        {
            _repository = repository;
        }
        IEnumerable<SchoolQueryResultDto> ISchoolGetAllQuery.GetAll()
        {
            return _repository.GetAll();
        }
    }
}
