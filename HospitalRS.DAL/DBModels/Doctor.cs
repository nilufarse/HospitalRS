using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRS.DAL.DBModels
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Speciast { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int? HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        //public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
