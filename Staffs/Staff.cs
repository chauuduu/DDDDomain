using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using Domain.LaundryInvoices;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Domain.Staffs
{
    [Table("Staff")]
    public class Staff
    {
        public Staff() { }
        public int Id { get; private set; }
        public string CitizenCode { get; private set; }
        public string FullName { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public int RoleId { get; private set; }
        public RoleStaff RoleStaff { get; private set; }
        public List<Invoice> Invoices { get; private set; } = new List<Invoice>();
        public List<LaundryInvoice> LaundryInvoices { get; private set; } = new List<LaundryInvoice>();
        public Staff(string citizenCode, string fullName, DateTime birthday, string phone, string address, int roleId)
        {
            Update(citizenCode,fullName,birthday,phone,address,roleId);
        }
        public void Update(string citizenCode, string fullName, DateTime birthday, string phone, string address, int roleId)
        {
            CitizenCode = citizenCode.Trim();
            FullName = fullName.Trim();
            Birthday = birthday;
            Phone = phone.Trim();
            Address = address.Trim();
            RoleId = roleId;
        }
    }
}
