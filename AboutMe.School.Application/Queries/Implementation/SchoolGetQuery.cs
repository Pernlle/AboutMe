using AboutMe.School.Application.Repositories;

namespace AboutMe.School.Application.Queries.Implementation
{
    public class SchoolGetQuery: ISchoolGetQuery
    {
        private readonly ISchoolRepository _repository;
        public SchoolGetQuery(ISchoolRepository repository)
        {
            _repository = repository;
        }
        SchoolQueryResultDto ISchoolGetQuery.Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
