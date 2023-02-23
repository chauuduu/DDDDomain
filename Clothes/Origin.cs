using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cloth
{
    [Table("Origin")]
    public class Origin
    {
        public Origin()
        {
            this.Clothes = new List<Clothes>();
        }

        [Key]
        [Required]
        public int IDOrigin { get; private set; }
        [MaxLength(50)]
        public string Name { get; private set; }
        [MaxLength(50)]
        public string Address { get; private set; }

        public Origin(int iDOrigin, string name, string address)
        {
            IDOrigin = iDOrigin;
            Name = name;
            Address = address;
        }

        public List<Clothes> Clothes { get; private set; }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeAddress(string value)
        {
            Address = value;
        }
    }
}
