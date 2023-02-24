using Domain.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllAsync();
        Task<String> InsertAsync(Staff p);
        Task<String> UpdateAsync(Staff p);
        Task<String> DeleteAsync(int Id);

    }
}
