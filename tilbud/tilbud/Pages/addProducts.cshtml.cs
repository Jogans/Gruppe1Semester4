using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace tilbud.Pages
{
    public class addProductsModel : PageModel
    {
        public string postVar { get; set; }

        public List<string> streng = new List<string>();

        public void OnGet()
        {
            //string connectionString;
            //SqlConnection con;
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36");

            var stream = client.OpenRead("http://skeldekrojmand.dk/tilbud.txt");
            var reader = new StreamReader(stream);
            String json = reader.ReadToEnd();
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
            
            /*foreach(JObject data in array.Children<JObject>())
            {
                foreach(JProperty prop in data.Properties())
                {
                    string propname = prop.Name;
                    if(propname.Equals("title"))
                    {
                        streng.Add((string) prop.Value+"\n");
                    }
                }
                
            }*/


            /*using (var db = new projtestContext())
            {
                var tekst = db.Tabel.ToList();
                foreach(var i in tekst)
                {
                    streng = i.Tekst;
                }
                var tabel = new Tabel();
                db.Tabel.Add(tabel);
                
            }*/


            //connectionString = @"Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=martin;Password=sY0$*68y!N0v";
            //con = new SqlConnection(connectionString);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //String sql;

            //con.Open();
            //sql = "INSERT INTO Vare VALUES ('Test',10,'Aldi','10-10-10,'12-10-10,25,500,'http://www.google.dk')";
            //SqlCommand com = new SqlCommand(sql, con);

            //adapter.InsertCommand = new SqlCommand(sql, con);
            //adapter.InsertCommand.ExecuteNonQuery();

            //com.Dispose();
            //con.Close();


            postVar = Request.Query["tekst"];
            
        }
    }
}