using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;
using Newtonsoft.Json.Linq;

namespace GuldtandMVC_Identity.Models
{
    public class ParseVarer
    {

        public static void InsertVare(string json)
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
                                string str = (string)prop.Value;
                                if (str.Length >= 49)
                                    vare.Navn = str.Substring(0, 49);
                                else
                                    vare.Navn = str;
                                break;
                            case "price":
                                vare.Pris = (double)prop.Value;
                                break;
                            case "customerName":
                                vare.Butik = (string)prop.Value;
                                break;
                            case "validFrom":
                                vare.ValidFra = new DateTime(2019, 10, 10, 20, 10, 20);
                                break;
                            case "validTo":
                                vare.ValidTil = new DateTime(2019, 10, 10, 20, 10, 20);
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

                        db.SaveChanges();
                    }




                }

            }
        }
    }
}
