using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Domain.Cloth
{
    [Table("Origin")]
    public class Origin
    {
        public Origin(){}
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        [JsonIgnore]
        public List<Clothes> Clothes { get; private set; } = new List<Clothes>();
        public Origin(string name, string address)
        {
            Update(name,address);
        }
        public void Update(string name, string address)
        {
            Name = name.Trim();
            Address = address.Trim();
        }
        
    }
}
