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
        public string FullName { get; private set; }
        public string Phone { get;  set; }
        public string Address { get; set; }

        public List<Invoice> Invoices { get; set; }

        public Customer(int iD, string fullName, string phone, string address, List<Invoice> invoices)
        {
            ID = iD;
            FullName = fullName;
            Phone = phone;
            Address = address;
            Invoices = invoices;
        }
        public void ChangeName(string name)
        {
            FullName = name;
        }

    }
}

