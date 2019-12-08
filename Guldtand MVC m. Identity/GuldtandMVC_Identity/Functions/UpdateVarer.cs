using GuldtandMVC_Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class UpdateVarer
    {
        public static void Update()
        {
            using (var db = new prj4databaseContext())
            {
                db.ProductCategory.RemoveRange(db.ProductCategory.Where(pc => pc.Product.ValidTo < DateTime.UtcNow));
                db.Product.RemoveRange(db.Product.Where(p => p.ValidTo < DateTime.UtcNow));
                db.SaveChanges();
            }
        }
    }
}
