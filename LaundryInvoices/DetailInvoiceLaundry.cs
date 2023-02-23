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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; private set; }
        public int IDLaundryInvoice { get; private set; }
        public int IDClothes { get; private set; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }

        public LaundryInvoice LaundryInvoice { get; private set; }
        public Clothes Cloth { get; private set; }

        public DetailInvoiceLaundry(int iD, int iDLaundryInvoice, int iDClothes, int price, int quantity, LaundryInvoice laundryInvoice, Clothes cloth)
        {
            ID = iD;
            IDLaundryInvoice = iDLaundryInvoice;
            IDClothes = iDClothes;
            Price = price;
            Quantity = quantity;
            LaundryInvoice = laundryInvoice;
            Cloth = cloth;
        }
    }
}

