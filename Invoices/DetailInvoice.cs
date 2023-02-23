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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        public int IDInvoice { get; private set; }
        public int IDClothes { get; private set; }
        public int Quantity { get; set; }

        public Invoice Invoice { get; set; }
        public Clothes Cloth { get; set; }

        public DetailInvoice(int iD, int iDInvoice, int iDClothes, int quantity, Invoice invoice, Clothes cloth)
        {
            ID = iD;
            IDInvoice = iDInvoice;
            IDClothes = iDClothes;
            Quantity = quantity;
            Invoice = invoice;
            Cloth = cloth;
        }
    }
}
