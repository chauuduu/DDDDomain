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
        public Laundry()
        {
            this.LaundryInvoices = new List<LaundryInvoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        [MaxLength(50)]
        public string Name { get; private set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public int? Rate { get; set; }

        public List<LaundryInvoice> LaundryInvoices { get; set; }

        public Laundry(int iD, string name, string phone, string address, int? rate, List<LaundryInvoice> laundryInvoices)
        {
            ID = iD;
            Name = name;
            Phone = phone;
            Address = address;
            Rate = rate;
            LaundryInvoices = laundryInvoices;
        }
    }
}
