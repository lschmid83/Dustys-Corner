using System.Collections.Generic;

namespace DustysCorner.Client.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string ImageTitle { get; set; }

        public string Thumbnail { get; set; }

        public virtual IEnumerable<ProductImageModel> AdditionalImages { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public bool LimitedStock { get; set; }

        public IEnumerable<ProductOptionModel> Options { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel Category { get; set; }

        public int Order { get; set; }

    }

}
