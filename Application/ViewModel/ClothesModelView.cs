using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public enum Status
    {
        Available,
        Rental,
        NeedToSell,
        Sold
    }
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public class ClothesModelView
    {
        public string Name { get;  set; }
        public string Description { get;  set; }
        public Size Size { get;  set; }
        public decimal Price { get;  set; }
        public int RentalTime { get;  set; }
        public int RentalPrice { get;  set; }
        public int TypeClothesId { get;  set; }
        public int OriginId { get;  set; }
        public Status Status { get;  set; }
    }
}
