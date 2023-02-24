using Application.Data;
using Application.ViewModel;
using Domain.Cloth;
using Infrastructure.Interface;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Application.Service.ClothService
{
    public class ClothesService : IClothesService
    {
        public string Add(Clothes Clothe)
        {
            using (var db = new MyDbContext())
            {
                Clothes Clo=new Clothes(Clothe.Name, Clothe.Description, Clothe.Size, Clothe.Price, Clothe.RentalPrice, Clothe.TypeClothesId, Clothe.OriginId, Clothe.Status);
                db.Add(Clothe);
                db.SaveChanges();
                return "Insert Success";
            }
        }

        public string Delete(int Id)
        {
            using (var db = new MyDbContext())
            {
                var Clothe = db.Clothes.Where(e => e.Id == Id).FirstOrDefault();
                if (Clothe == null) return "Delete failed";
                db.Clothes.Remove(Clothe);
                db.SaveChanges();
                return "Delete Success";
            }
        }

        public Clothes GetById(int Id)
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.SingleOrDefault(e => e.Id == Id);
                return rs;
            }
        }

        public List<Clothes> GetList()
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.ToList();
                return rs;
            }
        }

        public List<Clothes> GetListLike(string Name)
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.Where(e => e.Name.Contains(Name)).ToList();
                return rs;
            }
        }

        public string Update(int Id,Clothes Clothe)
        {
            using (var db = new MyDbContext())
            {
                Clothes ClothesBefore = db.Clothes.SingleOrDefault(e => e.Id == Id);
                if (ClothesBefore.Status== Domain.Cloth.Status.Available && Clothe.Status== Domain.Cloth.Status.Rental) 
                    ClothesBefore.ChangeRentalTime(); 
                ClothesBefore.Update(Clothe.Name, Clothe.Description, Clothe.Size, Clothe.Price, Clothe.RentalPrice, Clothe.TypeClothesId, Clothe.OriginId, Clothe.Status);
                db.SaveChanges();
                return "Update Success";
            }
        }
    }
}
