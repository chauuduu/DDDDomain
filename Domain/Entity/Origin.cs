using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class Origin
{
    public int OriginId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Clothe> Clothes { get; } = new List<Clothe>();
}
