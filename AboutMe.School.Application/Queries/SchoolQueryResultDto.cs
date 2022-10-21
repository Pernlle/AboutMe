
namespace AboutMe.School.Application.Queries
{
    public class SchoolQueryResultDto
    {
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        public int SchoolId { get; set; }
        public DateTime SchoolStartDate { get; set; }
        public DateTime SchoolEndDate { get; set; }
        public string FileName { get; set; } //DomainService? //FilePath //UploadedFile
        public byte[] RowVersion { get; set; }
    }
}
