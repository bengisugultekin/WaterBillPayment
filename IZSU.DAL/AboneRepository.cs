using IZSU.Entity.Model;
using IZSU.Entity.Model.DatabaseConnection;
using IZSU.Entity.Model.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace IZSU.DAL
{
    public class AboneRepository
    {
        public static List<ViewAbones> GetAllAbones()
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Abone.Select(a => new ViewAbones
                {
                    AboneID = a.AboneID,
                    AboneAdSoyad = a.AboneAdSoyad,
                    AboneTuruAd = a.AboneTuru.AboneTuruAd,
                }).ToList();
            }
        }

        public static void AddAbone(Abone abone)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                db.Abone.Add(abone);
                db.SaveChanges();
            }
        }

       


        public static void UpdateAbone(Abone abone)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                var result = db.Abone.FirstOrDefault(a => a.AboneID == abone.AboneID);
                result.AboneAdSoyad = abone.AboneAdSoyad;
                result.AboneTuruID = abone.AboneTuruID;
                db.SaveChanges();

            }
        }

        public static ViewAbones GetViewAbone(int no)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Abone.
                    Where(a => a.AboneID == no).
                    Select(a => new ViewAbones
                    {
                        AboneAdSoyad = a.AboneAdSoyad,
                        AboneTuruAd = a.AboneTuru.AboneTuruAd,
                    }).FirstOrDefault();
            }
        }

        public static void DeleteAbone(int no)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                var result = db.Abone.Where(a => a.AboneID == no).FirstOrDefault();
                db.Abone.Remove(result);
                db.SaveChanges();
            }
        }

        public static Abone FindAboneTuruID(int id)
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.Abone.FirstOrDefault(a => a.AboneID == id);
            }
                
        }
    }
}
