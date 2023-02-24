using Azure;
using Dapper;
using Domain.Cloth;
using Infrastructure.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClothesRepository : ConnectionDb.ConnectionDb, IClothesRepository
    {
        public ClothesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<string> DeleteAsync(int Id)
        {
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "delete from Clothes where ID=" + Id;
                try
                {
                    var result = conn.Query<Clothes>(sql);
                    return "Delete Success";
                }
                catch (Exception ex)
                {
                    return "Delete failed";
                    throw ex;
                }
            }
        }

        public async Task<IEnumerable<Clothes>> GetAllAsync()
        {
            /*
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                String sql = "select * from Clothes";
                var result = conn.Query<Clothes>(sql);
                return result;
            }*/
            throw new NotImplementedException();
        }

        public async Task<string> InsertAsync(Clothes p)
        {
            throw new NotImplementedException();
            /*
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                //String sql = "insert into Clothes(Name,Description,Size,Price,RentalTime,RentalPrice,IsRental,IDType,IDOrigin) values(N'"+p.Name+"',N'"+p.Description+"',N'"+p.Size+"',"+p.Price+",0,"+p.RentalPrice+",0,"+p.IDType+","+p.IDOrigin+")";
                try
                {
                    var result = conn.Query<Clothes>(sql);
                    return "Insert Success";
                }
                catch (Exception ex)
                {
                    return "Insert failed";
                    throw ex;
                }
            }*/
        }

        public Task<string> UpdateAsync(Clothes p)
        {
            throw new NotImplementedException();
        }
    }
}
