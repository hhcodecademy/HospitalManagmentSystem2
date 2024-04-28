using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem.Models
{
    public class Diagnostic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime DiagnosticDate { get; set; }
    }
}
