using Domain.LaundryInvoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ILaundryInvoiceRepository
    {
        Task<IEnumerable<LaundryInvoice>> GetAllAsync();
        Task<String> InsertAsync(LaundryInvoice p);
        Task<String> UpdateAsync(LaundryInvoice p);
        Task<String> DeleteAsync(int Id);

    }
}
