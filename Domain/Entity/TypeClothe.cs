using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class TypeClothe
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Limit { get; set; }

    public virtual ICollection<Clothe> Clothes { get; } = new List<Clothe>();
}
