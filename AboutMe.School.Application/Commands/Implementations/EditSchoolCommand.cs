using AboutMe.School.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.School.Application.Commands.Implementations
{
    public class EditSchoolCommand : IEditSchoolCommand
    {
        private readonly ISchoolRepository _Repository;
        public EditSchoolCommand(ISchoolRepository Repository)
        {
            _Repository = Repository;
        }
        void IEditSchoolCommand.Edit(SchoolCreateRequestDto requestDto)
        {
            var model = _Repository.Load(requestDto.SchoolId);
            model.Edit(requestDto.SchoolName, requestDto.SchoolDescription, requestDto.SchoolStartDate, requestDto.SchoolEndDate, requestDto.FileName);
            _Repository.Update(model);
        }
    }
}
