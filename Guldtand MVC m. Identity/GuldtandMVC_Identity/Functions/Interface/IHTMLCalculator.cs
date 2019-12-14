using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Models;

namespace GuldtandMVC_Identity.Functions
{
    public interface IHtmlCalculator
    {
        Task<double> NormalPrice(Recipe recipe, string word, string[] stores);

        Task<double> TotalPrice(Recipe recipe, string word, string[] stores);
    }
}
