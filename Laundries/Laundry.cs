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
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        private int rate = 1;
        public int Rate { 
            get { return rate; }
            private set
            {
                if (value >= 1 && value <= 5) rate = value;
            }
        }

        public List<LaundryInvoice> LaundryInvoices { get; private set; }

        public Laundry(int iD, string name, string phone, string address, int rate)
        {
            ID = iD;
            Name = name;
            Phone = phone;
            Address = address;
            Rate = rate;
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangePhone(string phone)
        {
            Phone = phone;
        }
        public void ChangeAddress(string address)
        {
            Address = address;
        }
        public void ChangeRate(int rate)
        {
            Rate = rate;
        }
    }
}
