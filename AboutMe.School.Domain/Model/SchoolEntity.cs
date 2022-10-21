using System.ComponentModel.DataAnnotations;

namespace AboutMe.School.Domain.Model
{
    public class SchoolEntity
    {
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        public int SchoolId { get; private set; }
        public DateTime SchoolStartDate { get; set; }
        public DateTime SchoolEndDate { get; set; }
        public string FileName { get; set; } //DomainService? //FilePath //UploadedFile

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public SchoolEntity(string schoolname, string schoolDescription, DateTime schoolstartDate, DateTime schoolEndDate, string fileName)
        {
            SchoolName = schoolname;
            SchoolDescription = schoolDescription;
            SchoolStartDate = schoolstartDate;
            SchoolEndDate = schoolEndDate;
            FileName = fileName;
        }
        internal SchoolEntity() { }
        public void Edit(string schoolname, string schoolDescription, DateTime schoolstartDate, DateTime schoolEndDate, string fileName)
        {
            SchoolName = schoolname;
            SchoolDescription = schoolDescription;
            SchoolStartDate = schoolstartDate;
            SchoolEndDate = schoolEndDate;
            FileName = fileName;
        }
    }
}
