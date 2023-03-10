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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; private set; }
        public int LaundryInvoiceId { get; private set; }
        public int ClothesId { get; private set; }
        public decimal Price { get; private set; }
        [ForeignKey("Id")]
        public LaundryInvoice LaundryInvoice { get; private set; }
        [ForeignKey("Id")]
        public Clothes Cloth { get; private set; }

        public DetailInvoiceLaundry(int laundryInvoiceId, int clothesId, decimal price)
        {
            if (Cloth.Status == Status.Available)
                Update(laundryInvoiceId,clothesId, price);
        }
        public void Update(int laundryInvoiceId, int clothesId, decimal price)
        {
            LaundryInvoiceId = laundryInvoiceId;
            ClothesId = clothesId;
            Price = price>0?price:0;
        }
    }
}

