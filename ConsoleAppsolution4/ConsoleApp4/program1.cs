using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class DoctorRepository
    {
        private List<Doctor> doctors;

        public DoctorRepository()
        {
            doctors = new List<Doctor>();
        }

        private int GetNextId()
        {
            if (doctors.Count == 0)
                return 1;
            int id = doctors[doctors.Count - 1].Id;
            return ++id;
        }

        private void TakeRemainingDoctorDetails(Doctor doctor)
        {
            Console.WriteLine("Please enter the doctor name");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Please enter the experience");
            doctor.Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter specialization");
            doctor.Specialisation = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            doctor.Phonenumber = Convert.ToDouble(Console.ReadLine());
        }

        public Doctor Add()
        {
            int id = GetNextId();
            Doctor doctor = new Doctor();
            doctor.Id = id;
            TakeRemainingDoctorDetails(doctor);
            doctors.Add(doctor);
            return doctor;
        }

        public List<Doctor> GetDoctors()
        {
            return doctors;
        }

        public Doctor GetDoctorById(int id)
        {
            foreach (var doc in doctors)
            {
                if (doc.Id == id)
                    return doc;
            }
            return null;
        }

        public Doctor Update(int id, Doctor doctor, string choice)
        {
            Doctor myDoctor = GetDoctorById(id);
            if (myDoctor != null)
            {
                if (choice == "Phonenumber")
                {
                    if (doctor.Phonenumber != 0)
                    {
                        myDoctor.Phonenumber = doctor.Phonenumber;
                        return myDoctor;
                    }
                }
                else if (choice == "Experience")
                {
                    if (doctor.Experience > 0)
                    {
                        myDoctor.Experience = doctor.Experience;
                        return myDoctor;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            Console.WriteLine("Could not update");
            return null;
        }

        public Doctor Delete(int id)
        {
            Doctor myDoctor = GetDoctorById(id);
            if (myDoctor != null)
            {
                doctors.Remove(myDoctor);
                Console.WriteLine("Doctor deleted");
                return myDoctor;
            }
            return null;
        }
    }
}
