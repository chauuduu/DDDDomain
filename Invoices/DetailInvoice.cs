using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Invoices
{
    [Table("DetailInvoice")]
    public class DetailInvoice
    {
        public DetailInvoice(){ }
        public int Id { get; private set; }
        public int InvoiceId { get; private set; }
        public int ClothesId { get; private set; }
        public Invoice Invoice { get; private set; }
        public Clothes Cloth { get; private set; }
        public DetailInvoice(int invoiceId, int clothesId)
        {
            if (Cloth.Status == Status.Available)
                Update(invoiceId, clothesId);
        }
        public void Update(int invoiceId, int clothesId)
        {
            InvoiceId = invoiceId;
            ClothesId = clothesId;
        }
    }
}
