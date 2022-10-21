
namespace AboutMe.Jobs.Application.Queries
{
    public interface IJobsGetAllQuery
    {
        IEnumerable<JobsQueryResultDto> GetAll();

    }
}
