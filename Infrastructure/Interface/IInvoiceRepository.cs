using Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IInvoiceRepository
    {
        Task<IEnumerable<Invoice>> GetAllAsync();
        Task<String> InsertAsync(Invoice p);
        Task<String> UpdateAsync(Invoice p);
        Task<String> DeleteAsync(int Id);

    }
}
