using Microsoft.EntityFrameworkCore;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DbContextClass dbContext) : base(dbContext)
        {}

        public IQueryable<Patient> GetPatientByPatientName(string patientName)
       => _dbContext.Patients.Where(x => (x.FirstName + x.LastName).Contains(patientName));

        public IQueryable<Patient> GetPatientById(int patientId)
            => _dbContext.Patients.Where(u => u.Id == patientId);
        public IQueryable<Patient> GetPatientAsQuarable()
            => _dbContext.Patients;


        IQueryable<Patient> IPatientRepository.GetPatientById(int patientId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GetPatientStatisticsDto> GetPatientStats()
        {

            var result = _dbContext.GetPatientStatisticsDto.FromSqlRaw("exec GetPatientStatistics");
            return result;


        }

    }
}
