using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record EmployersRollDTO
    {
        public int EmployerId { get; set; } = default;
        public int RollId { get; set; } = default;

        public EmployersRollDTO(int employerId, int rollId) => (EmployerId, RollId) = (employerId, rollId);

    }
}
