using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Functions
{
    public interface IAddHTMLToRecipe
    {
        Task<string> ShowRecipeFullView(string words, double antal);

        Task<string> GenerateShoppingCart(string words, string stores);
    }
}