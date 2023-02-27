using Domain.LaundryInvoices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Laundries
{
    [Table("Laundry")]
    public class Laundry
    {
        public Laundry(){}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Id { get; private set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; private set; }= "Unknown";
        [Required]
        [MaxLength(100)]
        public string Phone { get; private set; } = "Unknown";
        [Required]
        [MaxLength(100)]
        public string Address { get; private set; } = "Unknown";
        public int Rate { get; private set; }

        public List<LaundryInvoice> LaundryInvoices { get; private set; } = new List<LaundryInvoice>();

        public Laundry(string name, string phone, string address, int rate)
        {
            Update(name,phone, address, rate);  
        }
        public void Update(string name, string phone, string address, int rate)
        {
            Name = name.Trim();
            Phone = phone.Trim();
            Address = address.Trim();
            Rate = rate>0&&rate<=5?rate:1;
        }
    }
}
