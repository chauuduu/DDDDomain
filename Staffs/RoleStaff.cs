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
        public RoleStaff()
        {
            this.Staffs = new List<Staff>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        [MaxLength(50)]
        public string RoleName { get; private set; }

        public List<Staff> Staffs { get; private set; }

        public RoleStaff(int iD, string roleName)
        {
            ID = iD;
            RoleName = roleName;
        }
    }
}
