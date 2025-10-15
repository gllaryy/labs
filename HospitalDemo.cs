using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();

            Doctor doctor1 = new Doctor(1, "Коваленко Ігор", "Терапевт");
            Doctor doctor2 = new Doctor(2, "Петренко Олена", "Хірург");
            Doctor doctor3 = new Doctor(3, "Шевчук Марія", "Педіатр");

            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.AddDoctor(doctor3);

            Console.WriteLine();

            Patient patient1 = new Patient(1, "Коваленко Тарас", 45);
            Patient patient2 = new Patient(2, "Іваненко Ольга", 30);
            Patient patient3 = new Patient(3, "Сидоренко Петро", 60);
            Patient patient4 = new Patient(4, "Мельник Анастасія", 25);

            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);
            hospital.RegisterPatient(patient4);

            Console.WriteLine();

            HospitalRoom room101 = new HospitalRoom(101, 2);
            HospitalRoom room102 = new HospitalRoom(102, 1);
            HospitalRoom room103 = new HospitalRoom(103, 2);

            hospital.CreateRoom(room101);
            hospital.CreateRoom(room102);
            hospital.CreateRoom(room103);

            Console.WriteLine();

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 101);

            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 999);
            hospital.HospitalizePatient(999, 103);

            Console.WriteLine();

            MedicalRecord record1 = new MedicalRecord(
                patient1, doctor1,
                DateTime.Now.AddDays(-10),
                "Гіпертонія. Призначено лікування."
            );

            MedicalRecord record2 = new MedicalRecord(
                patient2, doctor2,
                DateTime.Now.AddDays(-5),
                "Операція на апендиксі."
            );

            MedicalRecord record3 = new MedicalRecord(
                patient1, doctor3,
                DateTime.Now.AddDays(-2),
                "Огляд дитини (обстеження)."
            );

            hospital.AddMedicalRecord(record1);
            hospital.AddMedicalRecord(record2);
            hospital.AddMedicalRecord(record3);

            Console.WriteLine();

            Console.WriteLine("--- ІСТОРІЯ ПАЦІЄНТА ---");

            List<MedicalRecord> history = hospital.GetPatientHistory(1);

            foreach (MedicalRecord record in history)
            {
                Console.WriteLine("  Дата: " + record.Date.ToShortDateString());
                Console.WriteLine("  Лікар: " + record.Doctor.Name);
                Console.WriteLine("  Опис: " + record.Description);
                Console.WriteLine();
            }

            Console.WriteLine(hospital.GetStatistics());

        }
    }
}
