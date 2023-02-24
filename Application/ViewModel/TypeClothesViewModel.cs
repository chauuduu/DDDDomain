using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class TypeClothesViewModel 
    {
        public string Name { get; private set; }
        public int Limit { get; private set; }

    }
}
