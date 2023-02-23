using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Domain.Cloth
{
    [Table("TypeClothes")]
    public class TypeClothes
    {
        public TypeClothes()
        {
            this.Clothes = new List<Clothes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IDType { get; private set; }
        [MaxLength(50)]
        public string Name { get; private set; }
        public int? Limit { get; private set; }

        public TypeClothes(int iDType, string name, int? limit)
        {
            IDType = iDType;
            Name = name;
            Limit = limit;
        }

        public List<Clothes> Clothes { get; private set; }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeLimit(int? value)
        {
            Limit = value;
        }
    }
}
