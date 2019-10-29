using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud
{
    public class parseVarer
    {
        public static void insertVare(string json)
        {
            JObject jo = JObject.Parse(json);
            var array = (JArray)jo["adverts"];

            using (var db = new prj4databaseContext())
            {
                foreach (JObject data in array.Children<JObject>())
                {
                    Vare vare = new Vare();
                    vare.Volumen = 500;
                    foreach (JProperty prop in data.Properties())
                    {
                        string propname = prop.Name;
                        switch (propname)
                        {
                            case "title":
                                vare.Navn = (string)prop.Value;
                                break;
                            case "price":
                                vare.Pris = (double)prop.Value;
                                break;
                            case "customerName":
                                vare.Butik = (string)prop.Value;
                                break;
                            case "validFrom":
                                vare.ValidFra = (string)prop.Value;
                                break;
                            case "validTo":
                                vare.ValidTil = (string)prop.Value;
                                break;
                            case "volumePrice":
                                vare.Volumenpris = (double)prop.Value;
                                break;
                            case "imageUrl":
                                vare.Imgsrc = (string)prop.Value;
                                break;
                        }


                    }
                    db.Vare.Add(vare);
                }
                db.SaveChanges();
            }
        }
    }
}
