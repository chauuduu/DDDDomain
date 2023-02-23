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
    [Table("Clothes")]
    public class Clothes
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string? Description { get;  set; }
        public string? Size { get;  set; }
        public int? Price { get;  set; }
        public int? RentalTime { get;  set; }
        public int? RentalPrice { get;  set; }
        public bool? IsRental { get;  set; }
        public int IDType { get; private set; }
        public int IDOrigin { get; private set; }
        public bool? IsSolve { get; set; }
        public Clothes(int iD, string name, string? description, string? size, int? price, int? rentalTime, int? rentalPrice, bool? isRental, int iDType, int iDOrigin,bool? isSolve)
        {
            ID = iD;
            Name = name;
            Description = description;
            Size = size;
            Price = price;
            RentalTime = rentalTime;
            RentalPrice = rentalPrice;
            IsRental = isRental;
            IDType = iDType;
            IDOrigin = iDOrigin;
            IsSolve = isSolve;
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeIsRentalTrue(int limit)
        {
            if (RentalTime <= limit) IsRental = true;
            else IsSolve = true;
            
        }
        public void ChangeIsRentalFalse(int limit)
        {
            IsRental = false;
            if (RentalTime == limit) IsSolve = true;
        }
    }
}

