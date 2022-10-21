
namespace AboutMe.School.Application.Commands
{
    public interface ICreateSchoolCommand
    {
        void Create(SchoolCreateRequestDto schoolCreateRequestDto);
    }
}
