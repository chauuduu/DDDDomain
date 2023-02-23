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
        public TypeClothes(){}
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Limit { get; private set; }
        public List<Clothes> Clothes { get; private set; } = new List<Clothes>();
        public TypeClothes(string name, int limit)
        {
            Update(name,limit);
        }
        public void Update(string name, int limit)
        {
            Name = name.Trim();
            Limit = limit>1?limit:1;
        }
    }
}
