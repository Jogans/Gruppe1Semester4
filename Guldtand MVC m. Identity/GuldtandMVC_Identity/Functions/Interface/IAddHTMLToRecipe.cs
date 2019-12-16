using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Functions
{
    public interface IAddHtmlToRecipe
    {
        Task<string> ShowRecipeFullView(string words, double antal, Prj4databaseContext context);

        Task<string> GenerateShoppingCart(string words, string stores, Prj4databaseContext context);

        Task<string> ShowRecipeSmallViewSearchAsync(string word, string stores, Prj4databaseContext context);

        Task<string> ShowRecipeSmallViewAsync(string stores, int count, Prj4databaseContext context);
    }
}