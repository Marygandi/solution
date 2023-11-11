using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    internal class DoctorDetails
    {
        private DoctorRepository doctorRepository;

        public DoctorDetails()
        {
            doctorRepository = new DoctorRepository();
        }

        void Display()
        {
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Doctor experience");
            Console.WriteLine("3. Delete Doctor");
            Console.WriteLine("4. Update doctor phone");
            Console.WriteLine("5. Print all details");
            Console.WriteLine("0. Exit");
        }

        void StartActivities()
        {
            int choice;

            do
            {
                Display();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye Bye");
                        break;
                    case 1:
                        doctorRepository.Add();
                        break;
                    case 2:
                        UpdateExp();
                        break;
                    case 3:
                        DeleteDoctor();
                        break;
                    case 4:UpdatePhn();
                        break;
                    case 5:
                        PrintAll();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (choice != 0);
        }

        private void PrintAll()
        {
            Console.WriteLine("******");
            var doctors = doctorRepository.GetDoctors();
            foreach (var item in doctors)
            {
                Console.WriteLine(item);
                Console.WriteLine("------");
            }
            Console.WriteLine("********");
        }

        int GetDoctorFromUser()
        {
            int id;
            Console.WriteLine("Please enter doctor id");
            id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        private void DeleteDoctor()
        {
            int id = GetDoctorFromUser();
            if (doctorRepository.Delete(id) != null)
                Console.WriteLine("Doctor deleted");
        }

        private void UpdatePhn()
        {
            var id = GetDoctorFromUser();
            Console.WriteLine("Please enter the new phone number");
            double phonenumber = Convert.ToDouble(Console.ReadLine());
            Doctor doctor = new Doctor();
            doctor.Phonenumber = phonenumber;
            doctor.Id = id;
            var result = doctorRepository.Update(id, doctor, "Phonenumber");
            if (result != null)
                Console.WriteLine("Update success");
        }
        private void UpdateExp()
        {
            var id = GetDoctorFromUser();
            Console.WriteLine("Please enter the new Experience");
            int experience = Convert.ToInt32(Console.ReadLine());
            Doctor doctor = new Doctor();
            doctor.Experience = experience;
            doctor.Id = id;
            var result = doctorRepository.Update(id, doctor, "Experience");
            if (result != null)
                Console.WriteLine("Update success");
            
                
            }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HospitalApp");
            DoctorDetails d = new DoctorDetails();
            d.StartActivities();
        }
    }
}

