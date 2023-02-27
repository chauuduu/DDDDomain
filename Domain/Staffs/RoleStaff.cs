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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Id { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; private set; } = "User";

        public List<Staff> Staffs { get; private set; } = new List<Staff>();

        public RoleStaff(string name)
        {
            Name = name.Trim();
        }
    }
}
