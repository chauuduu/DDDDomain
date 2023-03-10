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
using System.Text.Json.Serialization;

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
        private Clothes(){}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; private set; } = "Unknown Clothes";
        [Required]
        [MaxLength(50)]
        public string Description { get; private set; } = "None";
        public Size Size { get; private set; }
        public decimal Price { get; private set; }
        public int RentalTime { get; private set;}
        public int RentalPrice { get; private set; }
        [ForeignKey("Id")]
        public int TypeClothesId { get; private set; }
        [ForeignKey("Id")]
        public int OriginId { get; private set; }
        public Status Status { get; private set; }
        [JsonIgnore]
        public TypeClothes TypeClothes { get; private set; }
        [JsonIgnore]
        public Origin Origin { get; private set; }
        [JsonIgnore]
        public List<DetailInvoice> DetailInvoices { get; set; } = new List<DetailInvoice>();
        [JsonIgnore]
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; set; } = new List<DetailInvoiceLaundry>();

        public Clothes(string name, string description, Size size, decimal price, int rentalPrice, int typeClothesId, int originId, Status status)
        {
            RentalTime = 0;
            Update(name, description, size, price, rentalPrice, typeClothesId, originId, status);
        }
        public void Update(string name, string description, Size size, decimal price, int rentalPrice, int typeClothesId, int originId, Status status)
        {
            Name = name.Trim();
            Description = description.Trim();
            Size = size;
            Price = price>0?price:0;
            RentalPrice = rentalPrice>10000?rentalPrice:10000;
            TypeClothesId = typeClothesId;
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