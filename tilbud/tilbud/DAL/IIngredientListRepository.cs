using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tilbud;

namespace Transfer
{
    public interface IIngredientListRepository : IDisposable
    {
        IEnumerable<IngredientList> GetIngredientLists();
        IngredientList GetIngredientListByID(int ingredientListId);
        void InsertIngredientList(IngredientList ingredientList);
        void DeleteIngredientList(int ingredientListID);
        void UpdateIngredientList(IngredientList ingredientList);
        void Save();

    }
}
