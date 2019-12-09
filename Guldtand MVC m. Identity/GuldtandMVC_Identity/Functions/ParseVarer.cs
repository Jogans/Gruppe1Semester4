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
                    Product vare = new Product();
  
                    string kategori = "";
                    foreach (JProperty prop in data.Properties())
                    {
                        string propname = prop.Name;

                        switch (propname)
                        {
                            case "title":
                                string str = (string)prop.Value;
                                if (str.Length >= 49)
                                    vare.Name = str.Substring(0, 49);
                                else
                                    vare.Name = str;
                                break;
                            case "price":
                                vare.Price = (double)prop.Value;
                                break;
                            case "customerName":
                                string retailChain = (string)prop.Value;
                                if (db.RetailChain.Any(r => r.Name.Equals(retailChain)))
                                {
                                    var dbRetail = db.RetailChain.Where(r => r.Name.Equals(retailChain)).First();
                                    vare.RetailChainId = dbRetail.RetailChainId;
                                }
                                break;
                            case "validFrom":
                                vare.ValidFrom = DateTime.ParseExact((string)prop.Value, "MM/dd/yyyy HH:mm:ss", null);
                                break;
                            case "validTo":
                                vare.ValidTo = DateTime.ParseExact((string)prop.Value, "MM/dd/yyyy HH:mm:ss", null);
                                break;
                            case "volumePrice":
                                vare.VolumePrice = (double)prop.Value;
                                if (vare.VolumePrice != 0)
                                vare.Volume  = Math.Round((double)vare.Price / (double)vare.VolumePrice,2);
                                else
                                {
                                    vare.Volume = 0;
                                }
                                break;
                            case "imageUrl":
                                vare.ImgSrc = (string)prop.Value;
                                break;
                            case "category":
                                kategori = (string)prop.Value["name"];


                                break;
                        }

                        //foreach (var unwantedCategory in Unwanted)
                        //{
                        //    vare.UnwantedBool = kategori == unwantedCategory;
                        //}

                    }

                    //FILTERING
                    //******************//
                    //Check if name and store already exists


                    //filter based on Black list
                    if (db.Blacklist.Where(b => b.Category.Equals(kategori)).Any()) continue;

                    //if (vare.UnwantedBool != false) continue;

                    if (!db.Product.Any(v => v.Name == vare.Name && v.RetailChainId == vare.RetailChainId))
                    {
                        db.Product.Add(vare);

                        if (!db.Category.Any(k => k.CategoryName.Equals(kategori)))
                        {
                            db.Category.Add(new Category() { CategoryName = kategori });
                        }

                        db.SaveChanges();

                        var vk = new ProductCategory();
                        vk.ProductId = vare.ProductId;
                        vk.CategoryName = kategori;
                        db.ProductCategory.Add(vk);

                        db.SaveChanges();
                    }

                    // Check valid date 

                }
            }
        }
    }
}
