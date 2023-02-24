using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IClothesRepository
    {
        Task<IEnumerable<Clothes>> GetAllAsync();
        Task<String> InsertAsync(Clothes p);
        Task<String> UpdateAsync(Clothes p);
        Task<String> DeleteAsync(int Id);
    }
}
