using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Functions
{
    public interface IHtmlCalculator
    {
        Task<double> NormalPrice(Recipe recipe, string word, string[] stores, Prj4databaseContext context);

        Task<double> TotalPrice(Recipe recipe, string word, string[] stores, Prj4databaseContext context);
    }
}
