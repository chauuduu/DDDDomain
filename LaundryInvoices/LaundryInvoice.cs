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
        public LaundryInvoice() { }
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public int LaundryId { get; private set; }
        public int StaffId { get; private set; }
        public int Total { get; private set; }
        public Laundry Laundry { get; private set; }
        public Staff Staff { get; private set; }
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; private set; } = new List<DetailInvoiceLaundry>();
        public LaundryInvoice(DateTime date, int laundryId, int staffId, int total)
        {
            Update(DateTime.Now, laundryId, staffId, total);
        }
        public void Update(DateTime date, int laundryId, int staffId, int total)
        {
            Date = date;
            LaundryId = laundryId;
            StaffId = staffId;
            Total = total>0?total:0;
        }
    }
}

