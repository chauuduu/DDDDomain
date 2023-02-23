using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Staffs
{
    [Table("RoleStaff")]
    public class RoleStaff
    {
        public RoleStaff(){ }
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<Staff> Staffs { get; private set; } = new List<Staff>();

        public RoleStaff(string name)
        {
            Name = name.Trim();
        }
    }
}
