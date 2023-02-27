using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Customer
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
}
