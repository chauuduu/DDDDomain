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
        public int Quantity { get; private set; }
        public Invoice Invoice { get; private set; }
        public Clothes Cloth { get; private set; }
        public DetailInvoice(int invoiceId, int clothesId, int quantity)
        {
            if (Cloth.Status == Status.Available)
                Update(invoiceId, clothesId, 1);
        }
        public void Update(int invoiceId, int clothesId, int quantity)
        {
            InvoiceId = invoiceId;
            ClothesId = clothesId;
            Quantity = quantity>0?quantity:1;
        }
    }
}
