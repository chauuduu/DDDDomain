using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class DetailInvoice
{
    public int Id { get; set; }

    public int? Idinvoice { get; set; }

    public int? Idclothes { get; set; }

    public int? Quantity { get; set; }

    public virtual Clothe? IdclothesNavigation { get; set; }

    public virtual Invoice? IdinvoiceNavigation { get; set; }
}
