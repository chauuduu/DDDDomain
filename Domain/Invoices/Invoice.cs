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
        public Invoice() { }
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public int CustomerId { get; private set; }
        public int StaffId { get; private set; }
        public int Discount { get; private set; }
        public Customer Customer { get; private set; }
        public Staff Staff { get; private set; }
        public List<DetailInvoice> DetailInvoices { get; private set; } = new List<DetailInvoice>();
        public Invoice(int customerId, int staffId, int discount)
        {
            Update(DateTime.Now,customerId, staffId, discount);
        }
        public void Update(DateTime date, int customerId, int staffId, int discount)
        {
            Date = date;
            CustomerId = customerId;
            StaffId = staffId;
            Discount = discount>0?discount:0;
        }
    }
}

