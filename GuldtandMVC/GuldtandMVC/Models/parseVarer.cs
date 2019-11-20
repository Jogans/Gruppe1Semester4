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
            List<string> Unwanted = new List<string> {"Walkie-talkies","Vintertilbehør","Vin","Video","Vatpinde","Værktøj","Ure","Undertøj og strømper","Udelegetøj","Tv-tilbehør","TV","Tøjvask","Tøj","Tilbehør til tøj","Tilbehør til katte","Tilbehør til hunde","Tilbehør til fugle","Tasker og kufferter","Tandpleje","Tablets","Synspleje","Støvsugere","Stole","Stearinlys","Sportstøj","Spiritus","Spillekonsoller","Spillekonsol – tilbehør","Spil","Smykker","Slik","Skopleje ","Sko","Skitøj","Sikkerhed","Service og bestik","Senge og tilbehør","Scootere","Print, kopiér, scan og fax","Pleje af motorkøretøjer","Papirvarer","Overtøj til voksne","Overtøj til børn","Opvarmning","Optik","Opbevaring og organisering","Øl","Musikinstrumenter","Musik","Mobiltelefoner","Massage og afslapning","Maskinopvask","Maling","Måleudstyr","Madopbevaring","Lyskæder","Lyd","Lugtfjerner","Lommetørklæder","Linned og sengetøj","Lamper","Krukker","Kosmetik","Kortspil","Kort og telegrammer","Kontorredskaber","Kontorforsyning","Konserves og glas","Køkkenudstyr","Køkkenredskaber","Køkkenopbevaring","Kogegrej","Knive","Ketsjersport","Kampsport","Kameraer","Julebelysning","Jul","Isenkram","Indretning","Indendørs sport","Hynder","Hylder","Hygiejneartikler","Hvidevarer","Husholdningsartikler","Husholdningsapparater","Højttalere","Højtidsdekorationer","Hobby og håndarbejde","Hedvin","Haveplanter","Havearbejde","Hårstyling","Hårpleje","Gulvtæpper","Gryder og pander","Grill","GPS","Glas","Gaveindpakning","Gaveæsker","Gardiner","Friluftsliv","Fotofremkaldelse","Førstehjælpskasse","Fodbold","Fiktion","Fest og fejring","Energidrikke","Eludstyr","Elektronik tilbehør","Dukker og legetøjsfigurer","Drone","Deodorant","Dele og tilbehør til bil","Dekorationer","Cykeltilbehør","Computertilbehør","Computere","Catering","Camping og hiking","Byggematerialer","Brætspil","Brænde","Børnetøj","Børnesko","Børnebøger","Belysning","Barudstyr","Barbering og hårfjerning","Bageudstyr","Badeværelsestilbehør", "Badelegetøj","Bad og tøj ","Babytøj","alkoholiske drikkevarer","aktivittetsmåler","adventspynt","Bolig og indretning", "Indretning", "Sundhed og personlig pleje", "Rødvin", "Sodavand", "Cola", "Bad og krop", "Dekorationer", "Dekorationsfad", "Hudpleje", "Hvidvin", "Oplevelsesgaver" , "Pyntepuder", "Rengøringsmidler", "Sengetøj", "Sport, hobby og fritid", "Tøjvask", "Underholdning", "Balsam", "Belysning", "Bleer", "Bleskift", "Bodyshampoo", "Borde", "Bøger, film og musik", "Børne- og babyudstyr", "Deodorant", "Desinfektionsmidler", "Faglitteratur", "Glasrens", "Hus og have", "Hårpleje", "Jul", "Julekalender", "Kunstige blomster og planter", "Lanterner", "Lommetørklæder", "Lysestager", "Plaider", "Renseservietter", "Rosé", "Sengesæt", "Sengetæppe", "Shampoo", "Spejle", "Stout", "Tandpasta", "Tandpleje", "Toiletrens", "Træer", "Vaser", "Vaskemiddel", "Vaskepulver", "Vingummi ", "Vådservietter"};

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
                                vare.Price = (double)prop.Value;
                                break;
                            case "customerName":
                                string retailChain = (string)prop.Value;
                                if (db.RetailChain.Any(r => r.Name.Equals(retailChain))) {
                                    var dbRetail = db.RetailChain.Where(r => r.Name.Equals(retailChain)).First();
                                    vare.RetailChainId = dbRetail.RetailChainId;
                                }
                                
                                break;
                            case "validFrom":
                                vare.ValidFrom = DateTime.ParseExact((string)prop.Value,"MM/dd/yyyy HH:mm:ss",null);
                                break;
                            case "validTo":
                                vare.ValidTo = DateTime.ParseExact((string)prop.Value, "MM/dd/yyyy HH:mm:ss", null);
                                break;
                            case "volumePrice":
                                vare.VolumePrice = (double)prop.Value;
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
