using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Employer : IEntity
    {
        public int Id { get; set; }

        //nullable string property named Firstname and restrict it to 50 characters.
        [MaxLength(50), Required]
        public string? Firstname { get; set; }

        //nullable string property named Lastname and restrict it to 50 characters
        [MaxLength(50), Required]
        public string? Lastname { get; set; }

        public int Sallary { get; set; }
        public bool UnionMember { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department? Departments { get; set; }

        //to create an association between the Video and Course entities to define the first part of a one-tomany realtionship and easier navigation.
        public virtual ICollection<EmployersRoll>? EmployersRolls { get; set; }
    }
}
