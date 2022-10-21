
namespace AboutMe.Jobs.Application.Queries
{
    public class JobsQueryResultDto
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int JobId { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
