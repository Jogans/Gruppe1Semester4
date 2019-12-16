using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Functions
{
    public interface ICreateRecepieFromVue
    {
        string HtmlToRecipe(string name, int prepareTime, string description, string ingridientName,
            string ingridientAmount, string ingridientUnit, string imgUrl);

        Task<string> CreateRecipeToDatabase(string name, int prepareTime, string description, string ingridientName,
            string ingridientAmount, string ingridientUnit, string imgUrl, Prj4databaseContext context);
    }
}