using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class LaundryInvoice
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? Idlaundry { get; set; }

    public int? Idstaff { get; set; }

    public int? Total { get; set; }

    public virtual ICollection<DetailInvoiceLaundry> DetailInvoiceLaundries { get; } = new List<DetailInvoiceLaundry>();

    public virtual Laundry? IdlaundryNavigation { get; set; }

    public virtual Staff? IdstaffNavigation { get; set; }
}
