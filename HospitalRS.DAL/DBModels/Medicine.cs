using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRS.DAL.DBModels
{
   public class Medicine : BaseEntity
    {
        public string Name { get; set; }

        public string Company { get; set; }

        public decimal? Cost { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}
