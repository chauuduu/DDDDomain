using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using Domain.LaundryInvoices;
using System.Runtime.CompilerServices;

namespace Domain.Cloth
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
    [Table("Clothes")]
    public class Clothes
    {
        public Clothes(){}
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Size Size { get; private set; }
        public decimal Price { get; private set; }
        public int RentalTime { get; private set;}
        public int RentalPrice { get; private set; }
        public int TypeId { get; private set; }
        public int OriginId { get; private set; }
        public Status Status { get; private set; }
        public TypeClothes TypeClothes { get; private set; }

        public Clothes(string name, string description, Size size, decimal price, int rentalPrice, int typeId, int originId, Status status)
        {
            RentalTime = 0;
            Update(name, description, size, price, rentalPrice, typeId, originId, status);
        }
        public void Update(string name, string description, Size size, decimal price, int rentalPrice, int typeId, int originId, Status status)
        {
            Name = name.Trim();
            Description = description.Trim();
            Size = size;
            Price = price>0?price:0;
            RentalPrice = rentalPrice>10000?rentalPrice:10000;
            TypeId = typeId;
            OriginId = originId;
            Status = status;
        }
        public void ChangeStatus(Status status)
        {
            if (status != Status.Sold) Status = status;
        }
        public void ChangeRentalTime()
        {
            if (RentalTime < TypeClothes.Limit) RentalTime++;
            else Status = Status.NeedToSell;
        }
    }
}