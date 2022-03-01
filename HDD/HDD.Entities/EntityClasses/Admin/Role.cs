using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public string? RoleDescription { get; set; }
    }
}
