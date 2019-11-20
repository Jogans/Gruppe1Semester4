using GuldtandMVC_Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class blacklistModel
    {
        public blacklistModel()
        {

        }

        public string[] insertandgetBlackList(string category)
        {
            string initString = "<table border='1'><th>Blacklist</th>";
            string bodyString = "";
            string endString = "</table>";

            using (var db = new prj4databaseContext())
            {
                if (!db.Blacklist.Any(b => b.Category.Equals(category)))
                {
                    db.Blacklist.Add(new Blacklist { Category = category });
                    db.SaveChanges();
                }

                var blacklist = (from c in db.Blacklist select c.Category).ToArray();
                return blacklist;

               

            }
            

        }
    }
}
