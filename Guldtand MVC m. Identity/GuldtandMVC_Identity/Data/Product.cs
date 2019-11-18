using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Data
{
    public partial class Product
    {
        public Product()
        {
            Ingredient = new HashSet<Ingredient>();
            ProductCategory = new HashSet<ProductCategory>();
        }

        public int ProductId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
        public double? VolumePrice { get; set; }
        public string ImgSrc { get; set; }
        public int? RetailChainId { get; set; }

        public virtual RetailChain RetailChain { get; set; }
        public virtual ICollection<Ingredient> Ingredient { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
