using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.Jobs.Application.Commands
{
    public class JobsEditRequestDto
    {
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int JobId { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public byte[] RowVersion { get; set; }

    }
}
