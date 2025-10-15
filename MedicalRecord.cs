using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class MedicalRecord
    {
        public Patient Patient { get; }
        public Doctor Doctor { get; }
        public DateTime Date { get; }
        public string Description { get; }

        public MedicalRecord(Patient patient, Doctor doctor, DateTime date, string description)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }

    }
}
