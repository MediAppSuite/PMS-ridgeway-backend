using PMS.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;
using System.Diagnostics.CodeAnalysis;

namespace PMS.Core.Models
{
    public class PatientMedicalRecordDetails
    {
        [Key]
        public int PatientMedicalRecordID { get; set; }

        [ForeignKey("Patient")]
        public int PatientProfileID { get; set; }
        public virtual Patient? PatientProfile { get; set; }

        
        public long? BHTNumber { get; set; }

        [ForeignKey("Reason")]
        public long? ReasonID { get; set; }
        public virtual Reason? Reason { get; set; }

        public int? WardNumber { get; set; }
        public string? Background { get; set; }
        public string? Investigations { get; set; }
        public string? Treatments { get; set; }
        public string? DailyStatus { get; set; }
        public string? Plan { get; set; }
        public string? SpecialRemarks { get; set; }
        public DateTime? AdmittedDate { get; set; }
        public string? Fiepath { get; set; }
        public string? FieName { get; set; }
        public string? Diagnosis { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
