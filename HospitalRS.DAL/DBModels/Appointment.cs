using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRS.DAL.DBModels
{
   public class Appointment :BaseEntity
    {
        public int? DoctorId { get; set; }

        public  Doctor Doctor { get; set; }

        public string Phone { get; set; }

        public string Type { get; set; }

        public DateTime? Date { get; set; }

        public string Description { get; set; }
    }
}
