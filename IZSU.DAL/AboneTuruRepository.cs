using IZSU.Entity.Model;
using IZSU.Entity.Model.DatabaseConnection;
using System.Collections.Generic;
using System.Linq;

namespace IZSU.DAL
{
    public class AboneTuruRepository
    {
        public static List<AboneTuru> GetAllAboneTurus()
        {
            using (IzsuDBContext db = new IzsuDBContext())
            {
                return db.AboneTuru.ToList();
            }

        }
    }
}
