using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class Products
    {
        public Products()
        {
            IngredientList = new HashSet<IngredientList>();
        }

        public int ProductId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string RetailChain { get; set; }
        public decimal PriceRegular { get; set; }
        public decimal? PriceSale { get; set; }
        public decimal Amount { get; set; }
        public string AmountUnit { get; set; }
        public decimal? PricePrAmount { get; set; }
        public decimal? SavingsAbsolute { get; set; }
        public decimal? SavingsPercent { get; set; }

        public virtual RetailChains RetailChainNavigation { get; set; }
        public virtual ICollection<IngredientList> IngredientList { get; set; }
    }
}
