using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Models;

namespace GuldtandMVC_Identity.Functions
{
    public interface IHTMLCalculator
    {
        Task<double> NormalPrice(IEnumerable<Recipe> recipeList, string word, string[] stores);

        Task<double> TotalPrice(IEnumerable<Recipe> recipeList, string word, string[] stores);
    }
}
