using System;
using System.Linq;

namespace GuldtandMVC_Identity.Models
{
    public class UpdateVarer
    {
        public static void Update(Prj4databaseContext context)
        {
            context.ProductCategory.RemoveRange(context.ProductCategory.Where(pc => pc.Product.ValidTo < DateTime.UtcNow));
            context.Product.RemoveRange(context.Product.Where(p => p.ValidTo < DateTime.UtcNow));
            context.SaveChanges();
        }
    }
}
