using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Invoice
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? Idcustomer { get; set; }

    public int? Idstaff { get; set; }

    public int? Discount { get; set; }

    public int? Total { get; set; }

    public virtual ICollection<DetailInvoice> DetailInvoices { get; } = new List<DetailInvoice>();

    public virtual Customer? IdcustomerNavigation { get; set; }

    public virtual Staff? IdstaffNavigation { get; set; }
}
