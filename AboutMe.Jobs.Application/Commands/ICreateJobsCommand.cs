
namespace AboutMe.Jobs.Application.Commands
{
    public interface ICreateJobsCommand
    {
        void Create(JobsCreateRequestDto JobsCreateRequestDto);

    }
}
