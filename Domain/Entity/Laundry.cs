using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Laundry
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? Rate { get; set; }

    public virtual ICollection<LaundryInvoice> LaundryInvoices { get; } = new List<LaundryInvoice>();
}
