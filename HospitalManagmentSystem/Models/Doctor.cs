using HospitalManagmentSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fatehername { get; set; }
        public GenderType Gender { get; set; }
        public string Occupation { get; set; }
        public Department Department { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
