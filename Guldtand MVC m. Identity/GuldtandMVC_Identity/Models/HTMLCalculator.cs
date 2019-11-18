using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using com.sun.org.apache.bcel.@internal.generic;
using GuldtandMVC_Identity.Data;
using jdk.nashorn.@internal.ir;

namespace GuldtandMVC_Identity.Models
{
    public class HTMLCalculator
    {
        public string totalPrice(string word)
        {
            string initString = "" + "<html>";
            string endString = "</html>";
            string bodyString = "";

            double totalPrice = 0;

            using (var db = new prj4databaseContext())
            {
                var result = from v in db.Recipe where v.Name.Contains(word) select v;

                foreach (var recipe in result)
                {
                    foreach (var ingredient in db.Ingredient.Where(i => i.IngredientListId == recipe.RecipeId))
                    {
                        foreach (var product in db.Product.Where(p => p.ProductId == ingredient.ProductId))
                        {
                            totalPrice += product.Price;
                        }
                    }

                    bodyString += "<h1>" + totalPrice + "</h1>";
                }

                return initString + bodyString + endString;
            }
        }
    }
}
