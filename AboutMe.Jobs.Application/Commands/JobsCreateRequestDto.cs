
namespace AboutMe.Jobs.Application.Commands
{
    public class JobsCreateRequestDto
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
    }
}
