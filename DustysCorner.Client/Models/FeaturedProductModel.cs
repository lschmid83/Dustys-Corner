namespace DustysCorner.Client.Models
{
    public class FeaturedProductModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public ProductModel Product { get; set; }
    }
}