using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRS.DAL.DBModels
{
  public  class Patient : BaseEntity
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string BloodGroup { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int? DoctorId { get; set; }

        public Doctor Doctor { get; set; }
        bawim cixmadi(
        


    }
}
