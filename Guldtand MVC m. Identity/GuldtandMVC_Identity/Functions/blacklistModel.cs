using System.Linq;
using GuldtandMVC_Identity.Functions;

namespace GuldtandMVC_Identity.Models
{
    public class BlacklistModel : IBlacklistModel
    {
        public BlacklistModel()
        {

        }

        public string[] InsertandgetBlackList(string category, Prj4databaseContext context)
        {
            if (!context.Blacklist.Any(b => b.Category.Equals(category)))
            {
                context.Blacklist.Add(new Blacklist { Category = category });
                context.SaveChanges();
            }

            var blacklist = (from c in context.Blacklist select c.Category).ToArray();
            return blacklist;
        }
    }
}
