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
        public string CitizenCode { get; private set; }
        public string FullName { get; private set; }
        public DateTime? Birthday { get; private set; }

        public string Phone { get; private set; }
        public string Address { get; private set; }
        public int IDRole { get; private set; }

        public RoleStaff RoleStaff { get; private set; }
        public List<Invoice> Invoices { get; private set; }
        public List<LaundryInvoice> LaundryInvoices { get; private set; }

        public Staff(int iD, string citizenCode, string fullName, DateTime? birthday, string phone, string address, int iDRole, RoleStaff roleStaff)
        {
            ID = iD;
            CitizenCode = citizenCode;
            FullName = fullName;
            Birthday = birthday;
            Phone = phone;
            Address = address;
            IDRole = iDRole;
            RoleStaff = roleStaff;
        }
        public void ChangeCitizenCode(string citizenCode)
        {
            CitizenCode = citizenCode;
        }
        public void ChangeName(string name)
        {
            FullName = name;
        }
        public void ChangeBirthday(DateTime? birthday)
        {
            Birthday = birthday;
        }
        public void ChangePhone(string phone)
        {
            Phone = phone;
        }
        public void ChangeAddress(string address)
        {
            Address = address;
        }
        public void ChangeIDRike(int idRole)
        {
            IDRole= idRole;
        }
        
    }
}
