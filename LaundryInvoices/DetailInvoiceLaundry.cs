using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LaundryInvoices
{
    [Table("DetailInvoiceLaundry")]
    public class DetailInvoiceLaundry
    {
        public DetailInvoiceLaundry() { }
        public int Id { get; private set; }
        public int LaundryInvoiceId { get; private set; }
        public int ClothesId { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }
        public LaundryInvoice LaundryInvoice { get; private set; }
        public Clothes Cloth { get; private set; }

        public DetailInvoiceLaundry(int laundryInvoiceId, int clothesId, int price, int quantity)
        {
            if (Cloth.Status == Status.Available)
                Update(laundryInvoiceId,clothesId, price, quantity);
        }
        public void Update(int laundryInvoiceId, int clothesId, int price, int quantity)
        {
            LaundryInvoiceId = laundryInvoiceId;
            ClothesId = clothesId;
            Price = price>0?price:0;
            Quantity = quantity>0?quantity:1;
        }
    }
}

