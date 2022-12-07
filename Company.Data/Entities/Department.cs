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
    public class Department : IEntity
    {
        public int Id { get; set; }

        //nullable string property named Departmentname and restrict it to 50 characters.
        [MaxLength(50), Required]
        public string? Departmentname { get; set; }

        public int CompanyId { get; set; }
        public virtual MyCompany? Company { get; set; }

        //to create an association between the Video and Course entities to define the first part of a one-tomany realtionship and easier navigation.
        public virtual ICollection<Employer>? Employers { get; set; }
    }
}
