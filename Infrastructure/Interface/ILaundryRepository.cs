using Domain.Laundries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ILaundryRepository
    {
        Task<IEnumerable<Laundry>> GetAllAsync();
        Task<String> InsertAsync(Laundry p);
        Task<String> UpdateAsync(Laundry p);
        Task<String> DeleteAsync(int Id);

    }
}
