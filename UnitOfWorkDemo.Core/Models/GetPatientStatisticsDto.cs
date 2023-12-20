using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Models.DTO
{
    public class GetPatientStatisticsDto
    {
        public int TotalPatients { get; set; }
        public int NewPatientsToday { get; set; }
        public int NewPatientsThisWeek { get; set; }
        public int ActivePatients { get; set; }
    }
}
