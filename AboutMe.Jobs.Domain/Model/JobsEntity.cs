using System.ComponentModel.DataAnnotations;

namespace AboutMe.Jobs.Domain.Model
{
    public class JobsEntity
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int JobId { get; private set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }


        //public string FileName { get; set; } //DomainService? //FilePath //UploadedFile

        public JobsEntity(string jobTitle, string jobDescription, DateTime jobStartDate, DateTime jobEndDate)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            JobStartDate = jobStartDate;
            JobEndDate = jobEndDate;
        }
        internal JobsEntity() { }
        public void Edit(string jobTitle, string jobDescription, DateTime jobStartDate, DateTime jobEndDate)
        {
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            JobStartDate = jobStartDate;
            JobEndDate = jobEndDate;
        }
    }
}
