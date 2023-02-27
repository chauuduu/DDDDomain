using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Staff
{
    public int Id { get; set; }

    public string? Cccd { get; set; }

    public string? FullName { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? Idrole { get; set; }

    public virtual RoleStaff? IdroleNavigation { get; set; }

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    public virtual ICollection<LaundryInvoice> LaundryInvoices { get; } = new List<LaundryInvoice>();
}
