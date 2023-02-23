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
        public string? Description { get; private set; }
        public string? Size { get; private set; }
        public int? Price { get; private set; }
        private int rentalTime=0;
        public int RentalTime
        {
            get
            {
                return rentalTime;
            }
            private set
            {
                if (value >= 0) rentalTime = value;
            }
        }

        public Clothes()
        {
        }

        private int rentalPrice = 20000;
        public int RentalPrice
        {
            get
            {
                return rentalPrice;
            }
            private set
            {
                if (value >= 20000) rentalPrice = value;
            }
        }
        public bool IsRental { get; private set; }
        public int IDType { get; private set; }
        public int IDOrigin { get; private set; }
        public bool? IsSolve { get; private set; }
        public Clothes(int iD, string name, string? description, string? size, int? price, int rentalTime, int rentalPrice, bool isRental, int iDType, int iDOrigin,bool? isSolve)
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
        public void ChangeDescription(string? description)
        {
            Description = description;
        }
        public void ChangeSize(string? size)
        {
            Size = size;
        }
        public void ChangePrice(int price)
        {
            Price = price;
        }
        public void ChangeRentalTime()
        {
            RentalTime++;
        }
        public void ChangeRentalPrice(int rentalPrice)
        {
            RentalPrice = rentalPrice;
        }

        public void ChangeIsRental(int limit)
        {
            if (RentalTime >= limit)
            {
                IsSolve = true;
                IsRental = false;
            }
            else IsRental = !IsRental;

        }
        public void ChangeIDTypee(int iDType)
        {
            IDType = iDType;
        }
        public void ChangeIDOrigin(int iDOrigin)
        {
            IDOrigin = iDOrigin;
        }
        public void ChangeIsSolve()
        {
            IsSolve=!IsSolve;
        }
    }
}

