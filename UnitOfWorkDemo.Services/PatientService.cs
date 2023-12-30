using AutoMapper;
using PMS.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;
using UnitOfWorkDemo.Services.Interfaces;

namespace UnitOfWorkDemo.Services
{
    public class PatientService : IPatientService
    {
        public IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Patient> CreatePatient(PatientDto patientDetails)
        {
            if (patientDetails != null)
            {
                try
                {
                    var newPatient = new Patient()
                    {
                        Address = patientDetails.Address,
                        LastName = patientDetails.LastName,
                        Allergic = patientDetails.Allergic,
                        BloodGroup = patientDetails.BloodGroup,
                        ContactNumber = patientDetails.ContactNumber,
                        DateOfBirth = patientDetails.DateOfBirth,
                        EmergencyContactNo = patientDetails.EmergencyContactNo,
                        FirstName = patientDetails.FirstName,
                        Gender = patientDetails.Gender,
                      //  NIC = patientDetails.NIC, removed for now
                        MedicalHistory = patientDetails.MedicalHistory,
                        insuranceInfomation = patientDetails.insuranceInfomation,
                        isActive = patientDetails.isActive,
                        RegisteredDate = System.DateTime.Now

                    };

                    await _unitOfWork.Patient.Add(newPatient);
                    int result = _unitOfWork.Save();

                    if (result > 0)
                    {
                        // Mapping the newly created patient to a DTO and returning it
                        return (newPatient);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                    Console.WriteLine(ex.Message);
                    return new Patient();
                }
            }

            return new Patient();
        }
            public async Task<bool> DeletePatient(int patientId)
        {
            if (patientId > 0)
            {
                try
                {
                    Patient patientDetails = await _unitOfWork.Patient.GetById(patientId);
                    if (patientDetails != null)
                    {
                        _unitOfWork.Patient.Delete(patientDetails);
                        var result = _unitOfWork.Save();

                        if (result > 0)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            return false;
        }

        public async Task<IEnumerable<Patient>> GetAllpatients()
        {
            var patientList = await _unitOfWork.Patient.GetAll();
            return patientList;
        }

        public async Task<Patient> GetPatientById(int patientId)
        {
            if (patientId > 0)
            {
                var patientDetails = await _unitOfWork.Patient.GetById(patientId);
                if (patientDetails != null)
                {
                    return patientDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdatePatient(Patient patientDetails)
        {
            if (patientDetails != null)
            {
                var patient = await _unitOfWork.Patient.GetById(patientDetails.Id);
                if(patient != null)
                {
                    patient.FirstName = patientDetails.FirstName;
                    patient.LastName = patientDetails.LastName;
                    patient.DateOfBirth = patientDetails.DateOfBirth;
                    patient.Gender = patientDetails.Gender;
                    patient.ContactNumber = patientDetails.ContactNumber;
                    patient.Address = patientDetails.Address;
                    patient.EmergencyContactNo = patientDetails.EmergencyContactNo;
                    patient.BloodGroup = patientDetails.BloodGroup;
                    patient.MedicalHistory = patientDetails.MedicalHistory;
                    patient.Allergic = patientDetails.Allergic;
                   // patient.NIC = patientDetails.NIC;  removed  for now 
                    patient.insuranceInfomation = patientDetails.insuranceInfomation;
                    patient.isActive = patientDetails.isActive;
                    _unitOfWork.Patient.Update(patient);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public IQueryable<GetPatientStatisticsDto> GetPatientStats()
        {
            return _unitOfWork.Patient.GetPatientStats();
        }

        public IQueryable<Patient> GetPatientRecordsByPatientName(string patientName)
         => _unitOfWork.Patient.GetPatientByPatientName(patientName);

        public IQueryable<Patient> GetPatientRecordsAsQuarable()
            => _unitOfWork.Patient.GetPatientAsQuarable();

        public IQueryable<Patient> GetPatientRecordsById(int patientId)
            => _unitOfWork.Patient.GetPatientById(patientId);
    }
}
