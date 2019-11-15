using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC.Models
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
                    Product vare = new Product();
                    vare.Volume = 500;

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
                                vare.Price = (decimal)prop.Value;
                                break;
                            case "customerName":
                                string retailChain = (string)prop.Value;
                                if (db.RetailChain.Any(r => r.Name.Equals(retailChain))) {
                                    var dbRetail = db.RetailChain.Where(r => r.Name.Equals(retailChain)).First();
                                    vare.RetailChainId = dbRetail.RetailChainId;
                                }
                                
                                break;
                            case "validFrom":
                                vare.ValidFrom = new DateTime(2019, 10, 10, 20, 10, 20);
                                break;
                            case "validTo":
                                vare.ValidTo = new DateTime(2019, 10, 10, 20, 10, 20);
                                break;
                            case "volumePrice":
                                vare.VolumePrice = (decimal)prop.Value;
                                break;
                            case "imageUrl":
                                vare.ImgSrc = (string)prop.Value;
                                break;
                            case "category":
                                kategori = (string)prop.Value["name"];
                                break;
                        }


                    }

                    //FILTERING
                    //******************//
                    //Check if name and store already exists
                    
                    if (!db.Product.Any(v => v.Name == vare.Name && v.RetailChainId == vare.RetailChainId))
                    {
                        db.Product.Add(vare);

                        if (!db.Category.Any(k => k.CategoryName == kategori))
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




                }

            }
        }
    }
}
