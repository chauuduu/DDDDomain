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
        public Customer(){ }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; private set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; private set; } = "Unknown";
        [Required]
        [MaxLength(50)]
        public string Phone { get; private set; } = "Unknown";
        [Required]
        [MaxLength(50)]
        public string Address { get; private set; } = "Unknown";
        public List<Invoice> Invoices { get; private set; } = new List<Invoice>();
        public Customer(string fullName, string phone, string address)
        {
            Update(fullName, phone, address);
        }
        public void Update(string fullName, string phone, string address)
        {
            FullName = fullName.Trim()??"Unknown";
            Phone = phone.Trim();
            Address = address.Trim();
        }
    }
}

