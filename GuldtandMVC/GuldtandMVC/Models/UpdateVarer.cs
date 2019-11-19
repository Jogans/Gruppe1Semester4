using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC.Models
{
    public class UpdateVarer
    {
        public static void Update()
        {
            using(var db = new prj4databaseContext())
            {
                db.Product.RemoveRange(db.Product.Where(p => p.ValidTo < DateTime.UtcNow));
                db.SaveChanges();
            }
        }
    }
}
