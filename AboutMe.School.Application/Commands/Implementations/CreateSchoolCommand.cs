using AboutMe.School.Application.Repositories;
using AboutMe.School.Domain.Model;

namespace AboutMe.School.Application.Commands.Implementations
{
    public class CreateSchoolCommand : ICreateSchoolCommand
    {
        private readonly ISchoolRepository _schoolRepository;
        public CreateSchoolCommand(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        void ICreateSchoolCommand.Create(SchoolCreateRequestDto requestDto)
        {
            var school = new SchoolEntity(requestDto.SchoolName, requestDto.SchoolDescription, requestDto.SchoolStartDate, requestDto.SchoolEndDate, requestDto.FileName);
        }
    }
}
