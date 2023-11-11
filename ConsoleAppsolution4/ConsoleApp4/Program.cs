
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalApp
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Specialisation { get; set; }
        public double Phonenumber { get; set; }

        public Doctor()
        {
            Name = "mmm";
            Experience = 0;
            Specialisation = "Dentist";
        }

        public Doctor(int id, string name, int exp, string spl, double phn)
        {
            Id = id;
            Name = name;
            Experience = exp;
            Specialisation = spl;
            Phonenumber = phn;
        }

        public override string ToString()
        {
            return $"Doctor Id: {Id}\nDoctor Name: {Name}\nExperience: {Experience}\nSpecialization: {Specialisation}\nPhone Number: {Phonenumber}\n";
        }
    }
}

