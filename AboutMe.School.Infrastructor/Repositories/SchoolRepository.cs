using AboutMe.School.Domain.Model;
using AboutMe.School.Application.Queries;
using AboutMe.School.Application.Repositories;
using AboutMe.School.Domain.Model;
using AboutMe.SqlDB.Context;
using Microsoft.EntityFrameworkCore;

namespace AboutMe.School.Infrastructor.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AboutMeContext _db;
        public SchoolRepository(AboutMeContext db)
        {
            _db = db;
        }
        void ISchoolRepository.Add(SchoolEntity School)
        {
            _db.Add(School);
            _db.SaveChanges();
        }

        IEnumerable<SchoolQueryResultDto> ISchoolRepository.GetAll()
        {
            foreach (var entity in _db.SchoolEntities.AsNoTracking().ToList())
            {
                yield return new SchoolQueryResultDto
                { SchoolName = entity.SchoolName, SchoolDescription = entity.SchoolDescription, SchoolId = entity.SchoolId, SchoolStartDate = entity.SchoolStartDate, SchoolEndDate = entity.SchoolEndDate, FileName=entity.FileName, RowVersion = entity.RowVersion };
            }
        }

        void ISchoolRepository.Update(SchoolEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        SchoolEntity ISchoolRepository.Load(int id)
        {
            var dbEntity = _db.SchoolEntities.AsNoTracking().FirstOrDefault(a => a.SchoolId == id);
            if (dbEntity == null) throw new Exception("School måling findes ikke i Databasen");
            return dbEntity;
        }

        SchoolQueryResultDto ISchoolRepository.Get(int id)
        {
            var dbEntity = _db.SchoolEntities.AsNoTracking().FirstOrDefault(a => a.SchoolId == id);
            if (dbEntity == null) throw new Exception("School måling findes ikke i Databasen");

            return new SchoolQueryResultDto
            { SchoolName = dbEntity.SchoolName, SchoolDescription = dbEntity.SchoolDescription, SchoolId = dbEntity.SchoolId, SchoolStartDate = dbEntity.SchoolStartDate, SchoolEndDate = dbEntity.SchoolEndDate, FileName=dbEntity.FileName, RowVersion = dbEntity.RowVersion };
        }
    }
}
