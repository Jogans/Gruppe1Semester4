
namespace GuldtandMVC_Identity
{
    public partial class ProductCategory
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }

        public virtual Category CategoryNameNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
