using Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<String> InsertAsync(Customer p);
        Task<String> UpdateAsync(Customer p);
        Task<String> DeleteAsync(int Id);

    }
}
