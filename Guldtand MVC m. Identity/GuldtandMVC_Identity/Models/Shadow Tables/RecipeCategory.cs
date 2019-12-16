
namespace GuldtandMVC_Identity
{
    public partial class RecipeCategory
    {
        public int RecipeId { get; set; }
        public string CategoryName { get; set; }

        public virtual Category CategoryNameNavigation { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
