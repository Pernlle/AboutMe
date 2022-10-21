
using System.ComponentModel.DataAnnotations;

namespace AboutMe.School.Application.Commands
{
    public class SchoolEditRequestDto
    {
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        public DateTime SchoolStartDate { get; set; }
        public DateTime SchoolEndDate { get; set; }
        public string FileName { get; set; } //DomainService? //FilePath //UploadedFile
        public byte[] Rowversion { get; set; }
    }
}
