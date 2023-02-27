using System;
using System.Collections.Generic;

namespace ClothesRentalShop;

public partial class RoleStaff
{
    public int Idrole { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();
}
