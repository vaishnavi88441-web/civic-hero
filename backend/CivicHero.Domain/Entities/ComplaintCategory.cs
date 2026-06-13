using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CivicHero.Domain.Common;

namespace CivicHero.Domain.Entities;

public class ComplaintCategory : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public long DepartmentId { get; set; }

    public Department Department { get; set; } = null!;
}
