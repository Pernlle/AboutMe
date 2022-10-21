using AboutMe.Jobs.Application.Repositories;

namespace AboutMe.Jobs.Application.Queries.Implementation
{
    public class JobsGetAllQuery : IJobsGetAllQuery
    {
        private readonly IJobsRepository _repository;
        public JobsGetAllQuery(IJobsRepository repository)
        {
            _repository = repository;
        }
        IEnumerable<JobsQueryResultDto> IJobsGetAllQuery.GetAll()
        {
            return _repository.GetAll();
        }
    }
}
