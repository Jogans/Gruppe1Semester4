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

                        foreach (var unwantedCategory in Unwanted)
                        {
                            vare.UnwantedBool = kategori == unwantedCategory;
                        }
                        
                    }

                    //FILTERING
                    //******************//
                    //Check if name and store already exists


                    if (vare.UnwantedBool != false) continue;
                    if (!db.NyVare.Any(v => v.Navn == vare.Navn && v.Butik == vare.Butik))
                    {
                        db.NyVare.Add(vare);

                        if (!db.Kategori.Any(k => k.Kategori1 == kategori))
                        {
                            db.Kategori.Add(new Kategori() {Kategori1 = kategori});
                        }

                        var vk = new VareKategori();
                        vk.VareId = vare.VareId;
                        vk.Kategori = kategori;
                        db.VareKategori.Add(vk);

                        db.SaveChanges();
                    }

                    // Check valid date 

                }
            }
        }
    }
}
