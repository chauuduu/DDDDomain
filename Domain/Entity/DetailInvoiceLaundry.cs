using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class DetailInvoiceLaundry
{
    public int Id { get; set; }

    public int? IdlaundryInvoice { get; set; }

    public int? Idclothes { get; set; }

    public int? Price { get; set; }

    public int? Quantity { get; set; }

    public virtual Clothe? IdclothesNavigation { get; set; }

    public virtual LaundryInvoice? IdlaundryInvoiceNavigation { get; set; }
}
