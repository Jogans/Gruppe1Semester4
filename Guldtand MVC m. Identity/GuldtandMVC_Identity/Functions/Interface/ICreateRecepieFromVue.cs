using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Functions
{
    public interface ICreateRecepieFromVue
    {
        string HTMLToRecipe(string name, int prepareTime, string description, string ingridientName,
            string ingridientAmount, string ingridientUnit, string imgUrl);

        Task<string> CreateRecipeToDatabase(string name, int prepareTime, string description, string ingridientName,
            string ingridientAmount, string ingridientUnit, string imgUrl);
    }
}