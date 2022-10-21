
namespace AboutMe.School.Application.Commands
{
    public class SchoolCreateRequestDto
    {
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        public int SchoolId { get; set; }
        public DateTime SchoolStartDate { get; set; }
        public DateTime SchoolEndDate { get; set; }
        public string FileName { get; set; }
    }
}
