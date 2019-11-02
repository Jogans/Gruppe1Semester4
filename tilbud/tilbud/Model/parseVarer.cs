using Microsoft.EntityFrameworkCore.Internal;
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
                    NyVare vare = new NyVare();
                    vare.Volumen = 500;

                    string kategori = "";
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
                                vare.ValidFra = (DateTime)prop.Value;
                                break;
                            case "validTo":
                                vare.ValidTil = (DateTime)prop.Value;
                                break;
                            case "volumePrice":
                                vare.Volumenpris = (double)prop.Value;
                                break;
                            case "imageUrl":
                                vare.ImgSrc = (string)prop.Value;
                                break;
                            case "category":
                                kategori = (string)prop.Value["name"];
                                break;
                        }


                    }

                    if (!db.NyVare.Any(v => v.Navn == vare.Navn && v.Butik == vare.Butik))
                    {
                        db.NyVare.Add(vare);

                        if (!db.Kategori.Any(k => k.Kategori1 == kategori))
                        {
                            db.Kategori.Add(new Kategori() { Kategori1 = kategori });
                        }

                        var vk = new VareKategori();
                        vk.VareId = vare.VareId;
                        vk.Kategori = kategori;
                        db.VareKategori.Add(vk);
                    }




                }
                db.SaveChanges();
            }
        }
    }
}
