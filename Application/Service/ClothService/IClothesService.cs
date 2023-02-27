
using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.ClothService
{
    public interface IClothesService
    {
        List<Clothes> GetList();
        List<Clothes> GetListLike(string Name);
        Clothes GetById(int Id);

        string Add(Clothes Clothe);
        string Update(int Id,Clothes Clothe);
        string Delete(int Id);
    }
}
