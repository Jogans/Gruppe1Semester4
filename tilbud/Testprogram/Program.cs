using System;
using tilbud;
using Transfer.Models;

namespace Testprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            prj4databaseContext context = new prj4databaseContext();
            VareRepository objekt = new VareRepository(context);

            Vare var1 = new Vare();
            //var1.VareId = 50000;
            var1.Navn = "Testvare";
            var1.Pris = 2000.0;
            var1.Butik = "Netto";
            var1.ValidFra = "";
            var1.ValidTil = "";
            var1.Volumenpris = 100;
            var1.Volumen = 200;
            var1.Imgsrc = "";
            
            objekt.InsertVare(var1);
            objekt.Save();
        }
    }
}
