using IZSU.Entity.Model;
using IZSU.Entity.Model.DatabaseConnection;
using System.Collections.Generic;
using System.Linq;

namespace IZSU.DAL
{
    public class FaturaRepository
    {
        public static List<Fatura> GetAllFaturas()
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Fatura.ToList();
            }

       }


        public static List<Fatura> GetListeFatura(int id)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Fatura.Where(f => f.AboneID == id).ToList();
            }
        }

        public static Fatura GetFatura(int id)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Fatura.OrderByDescending(f => f.FaturaID).FirstOrDefault(f => f.AboneID == id);
            }
        }

        public static void AddFatura(Fatura fatura)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                db.Fatura.Add(fatura);
                db.SaveChanges();
            }
        }

        public static List<Fatura> GetOdenmemisFaturalar(int id)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Fatura.Where(f => f.AboneID == id && f.Tahsilat == false).ToList();
            }
        }

        public static void UpdateOdenenFatura(int faturaID)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
               var result =  db.Fatura.Find(faturaID);
                result.Tahsilat = true;

                db.SaveChanges();
            }
        }
    }
}
