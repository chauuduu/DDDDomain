using Domain.Customers;
using Domain.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    [Table("Invoice")]
    public class Invoice
    {
        public Invoice()
        {
            this.DetailInvoices = new List<DetailInvoice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int IDCustomer { get; private set; }
        public int IDStaff { get; private set; }
        public int? Discount { get; set; }
        public int Total { get; private set; }

        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
        public List<DetailInvoice> DetailInvoices { get; set; }

        public Invoice(int iD, DateTime date, int iDCustomer, int iDStaff, int? discount, int total, Customer customer, Staff staff, List<DetailInvoice> detailInvoices)
        {
            ID = iD;
            Date = date;
            IDCustomer = iDCustomer;
            IDStaff = iDStaff;
            Discount = discount;
            Total = total;
            Customer = customer;
            Staff = staff;
            DetailInvoices = detailInvoices;
        }
    }
}

