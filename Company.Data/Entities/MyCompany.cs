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
    public class MyCompany : IEntity
    {
        public int Id { get; set; }

        //nullable string property named Companyname and restrict it to 50 characters.
        [MaxLength(50), Required]
        public string? Companyname { get; set; }

        //nullable string property named Organisationno and restrict it to 12 characters
        [MaxLength(12)]
        public string? Organisationno { get; set; }

        //nullable string property named Land and restrict it to 50 characters
        [MaxLength(50)]
        public string? Land { get; set; }

        //to create an association between the Video and Course entities to define the first part of a one-tomany realtionship and easier navigation.
        public virtual ICollection<Department>? Departments { get; set; }
    }
}
