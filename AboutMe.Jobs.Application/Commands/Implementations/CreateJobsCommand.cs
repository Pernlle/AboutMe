using AboutMe.Jobs.Application.Repositories;
using AboutMe.Jobs.Domain.Model;

namespace AboutMe.Jobs.Application.Commands.Implementations
{
    public class CreateJobsCommand : ICreateJobsCommand
    {
        private readonly IJobsRepository _jobsRepository;
        public CreateJobsCommand(IJobsRepository jobsRePository)
        {
            _jobsRepository = jobsRePository;
        }
        void ICreateJobsCommand.Create(JobsCreateRequestDto jobsCreateRequestDto)
        {
            var jobs = new JobsEntity( jobsCreateRequestDto.JobTitle, jobsCreateRequestDto.JobDescription, jobsCreateRequestDto.JobStartDate, jobsCreateRequestDto.JobEndDate);
            _jobsRepository.Add(jobs);
        }
    }
}
