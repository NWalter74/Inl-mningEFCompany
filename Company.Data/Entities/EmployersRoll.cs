using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployersRoll : IReferenceEntity
    {
        public int EmployerId { get; set; }
        public int RollId { get; set; }

        public virtual Employer? Employers { get; set; }
        public virtual Roll? Rolls { get; set; }
    }
}
