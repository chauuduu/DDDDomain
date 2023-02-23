using Domain.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Laundries;

namespace Domain.LaundryInvoices
{
    [Table("LaundryInvoice")]
    public class LaundryInvoice
    {
        public LaundryInvoice()
        {
            this.DetailInvoiceLaundries = new List<DetailInvoiceLaundry>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        public DateTime? Date { get; private set; }
        public int IDLaundry { get; private set; }
        public int IDStaff { get; private set; }
        public int Total { get; private set; }

        public Laundry Laundry { get; private set; }
        public Staff Staff { get; private set; }
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; private set; }

        public LaundryInvoice(int iD, DateTime? date, int iDLaundry, int iDStaff, int total, Laundry laundry, Staff staff)
        {
            ID = iD;
            Date = date;
            IDLaundry = iDLaundry;
            IDStaff = iDStaff;
            Total = total;
            Laundry = laundry;
            Staff = staff;
        }
    }
}

