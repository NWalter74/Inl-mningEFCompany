using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record DepartmentDTO
    {
        public int Id { get; set; }
        public string? Departmentname { get; set; }
        public int CompanyId { get; set; }
    }
}
