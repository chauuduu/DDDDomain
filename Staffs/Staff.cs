using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using Domain.LaundryInvoices;

namespace Domain.Staffs
{
    [Table("Staff")]
    public class Staff
    {
        public Staff()
        {
            this.Invoices = new List<Invoice>();
            this.LaundryInvoices = new List<LaundryInvoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        [MaxLength(50)]
        public string CCCD { get; private set; }
        [MaxLength(50)]
        public string FullName { get; private set; }
        public DateTime? Birthday { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public int IDRole { get; set; }

        public RoleStaff RoleStaff { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<LaundryInvoice> LaundryInvoices { get; set; }

        public Staff(int iD, string cCCD, string fullName, DateTime? birthday, string phone, string address, int iDRole, RoleStaff roleStaff)
        {
            ID = iD;
            CCCD = cCCD;
            FullName = fullName;
            Birthday = birthday;
            Phone = phone;
            Address = address;
            IDRole = iDRole;
            RoleStaff = roleStaff;
        }
    }
}
