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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Id { get; private set; }
        public DateTime Date { get; private set; } = DateTime.Now;
        public int LaundryId { get; private set; }
        public int StaffId { get; private set; }
        [ForeignKey("Id")]
        public Laundry Laundry { get; private set; }
        [ForeignKey("Id")]
        public Staff Staff { get; private set; }
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; private set; } = new List<DetailInvoiceLaundry>();
        public LaundryInvoice(DateTime date, int laundryId, int staffId)
        {
            Update(DateTime.Now, laundryId, staffId);
        }
        public void Update(DateTime date, int laundryId, int staffId)
        {
            Date = date;
            LaundryId = laundryId;
            StaffId = staffId;
        }
    }
}

