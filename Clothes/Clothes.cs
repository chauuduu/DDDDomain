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
    public enum status
    {
        Available,
        Rental,
        NeedToSell,
        Sold
    }
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
        private int rentalTime = 0;
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
        public int IDType { get; private set; }
        public int IDOrigin { get; private set; }

        public status Status { get; private set; }
        public Clothes()
        {
        }

        public Clothes(int iD, string name, string? description, string? size, int? price, int rentalTime, int rentalPrice, int iDType, int iDOrigin, status status)
        {
            ID = iD;
            Name = name;
            Description = description;
            Size = size;
            Price = price;
            RentalTime = rentalTime;
            RentalPrice = rentalPrice;
            IDType = iDType;
            IDOrigin = iDOrigin;
            Status = status;
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

        public void ChangeStatus(status stt, int limit)
        {
            Status = stt;
            if (stt!=status.Sold && limit <= RentalTime) Status = status.NeedToSell;
        }
        public void ChangeIDTypee(int iDType)
        {
            IDType = iDType;
        }
        public void ChangeIDOrigin(int iDOrigin)
        {
            IDOrigin = iDOrigin;
        }

    }
}