using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ITypeClothesRepository
    {
        List<TypeClothes> GetList();
        TypeClothes GetById(int Id);

        String Add(TypeClothes TypeClothes);
        String Update(int Id, TypeClothes TypeClothes);
        String Delete(int Id);
    }
}
