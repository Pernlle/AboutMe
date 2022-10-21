using AboutMe.Jobs.Domain.Model;
using AboutMe.Jobs.Application.Queries;

namespace AboutMe.Jobs.Application.Repositories
{
    public interface IJobsRepository
    {
        void Add(JobsEntity Jobs);
        IEnumerable<JobsQueryResultDto> GetAll();
        JobsEntity Load(int id);
        void Update(JobsEntity model);
        JobsQueryResultDto Get(int id); 
    }
}
