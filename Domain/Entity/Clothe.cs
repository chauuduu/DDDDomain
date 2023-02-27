using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Clothe
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Size { get; set; }

    public decimal? Price { get; set; }

    public int? RentalTime { get; set; }

    public int? RentalPrice { get; set; }

    public int? TypeClothesId { get; set; }

    public int? OriginId { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<DetailInvoiceLaundry> DetailInvoiceLaundries { get; } = new List<DetailInvoiceLaundry>();

    public virtual ICollection<DetailInvoice> DetailInvoices { get; } = new List<DetailInvoice>();

    public virtual Origin? Origin { get; set; }

    public virtual TypeClothe? TypeClothes { get; set; }
}
