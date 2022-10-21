using AboutMe.Jobs.Application.Repositories;
using AboutMe.Jobs.Domain.Model;

namespace AboutMe.Jobs.Application.Commands.Implementations
{
    public class EditJobsCommand: IEditJobsCommand
    {
        private readonly IJobsRepository _repository;
        public EditJobsCommand(IJobsRepository repository)
        {
            _repository = repository;
        }

        void IEditJobsCommand.Edit(JobsEditRequestDto requestDto)
        {
            //Read
            var model = _repository.Load(requestDto.JobId);
            //DoIt
            model.Edit(requestDto.JobTitle, requestDto.JobDescription, requestDto.JobStartDate, requestDto.JobEndDate);
            //Save
            _repository.Update(model);
        }
    }
}
