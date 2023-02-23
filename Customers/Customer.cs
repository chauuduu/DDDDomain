using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using System.Xml.Linq;

namespace Domain.Customers
{
    [Table("Customer")]
    public class Customer
    {
        public Customer()
        {
            this.Invoices = new List<Invoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        public string FullName { get; private set; } = "Unknown";
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public List<Invoice> Invoices { get; private set; }

        public Customer(int iD, string fullName, string phone, string address)
        {
            ID = iD;
            FullName = fullName;
            Phone = phone;
            Address = address;
        }
        public void ChangeName(string name)
        {
            FullName = name;
        }
        public void ChangePhone(string phone)
        {
            Phone = phone;
        }
        public void ChangeAddress(string address)
        {
            Address = address;
        }

    }
}

