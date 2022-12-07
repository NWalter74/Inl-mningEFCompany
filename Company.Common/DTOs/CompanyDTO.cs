using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record CompanyDTO
    {
        public int Id { get; set; }
        public string? Companyname { get; set; }
        public string? Organisationno { get; set; }
        public string? Land { get; set; }
    }
}
