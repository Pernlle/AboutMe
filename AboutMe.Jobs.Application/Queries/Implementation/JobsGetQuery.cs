using AboutMe.Jobs.Application.Repositories;

namespace AboutMe.Jobs.Application.Queries.Implementation
{
    public class JobsGetQuery : IJobsGetQuery
    {
        private readonly IJobsRepository _repository;
        public JobsGetQuery(IJobsRepository repository)
        {
            _repository = repository;
        }
        JobsQueryResultDto IJobsGetQuery.Get(int id)
        {
            return _repository.Get(id);
        }
    }
}
