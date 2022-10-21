using AboutMe.Jobs.Application.Queries;
using AboutMe.Jobs.Application.Repositories;
using AboutMe.Jobs.Domain.Model;
using AboutMe.SqlDB.Context;
using Microsoft.EntityFrameworkCore;

namespace AboutMe.Jobs.Infrastructor.Repositories
{
    public class JobsRepository : IJobsRepository
    {
        private readonly AboutMeContext _db;
        public JobsRepository(AboutMeContext db)
        {
            _db = db;
        }
        void IJobsRepository.Add(JobsEntity Jobs)
        {
            _db.Add(Jobs);
            _db.SaveChanges();
        }

        IEnumerable<JobsQueryResultDto> IJobsRepository.GetAll()
        {
            foreach (var entity in _db.JobsEntities.AsNoTracking().ToList())
            {
                yield return new JobsQueryResultDto
                { JobTitle = entity.JobTitle, JobDescription = entity.JobDescription, JobId = entity.JobId, JobStartDate = entity.JobStartDate, JobEndDate = entity.JobEndDate, RowVersion = entity.RowVersion };
            }
        }

        void IJobsRepository.Update(JobsEntity model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }

        JobsEntity IJobsRepository.Load(int id)
        {
            var dbEntity = _db.JobsEntities.AsNoTracking().FirstOrDefault(a => a.JobId == id);
            if (dbEntity == null) throw new Exception("Jobs måling findes ikke i Databasen");
            return dbEntity;
        }

        JobsQueryResultDto IJobsRepository.Get(int id)
        {
            var dbEntity = _db.JobsEntities.AsNoTracking().FirstOrDefault(a => a.JobId == id);
            if (dbEntity == null) throw new Exception("Jobs måling findes ikke i Databasen");

            return new JobsQueryResultDto
            { JobTitle = dbEntity.JobTitle, JobDescription = dbEntity.JobDescription, JobId = dbEntity.JobId, JobStartDate = dbEntity.JobStartDate, JobEndDate = dbEntity.JobEndDate, RowVersion = dbEntity.RowVersion };
        }
    }
}
