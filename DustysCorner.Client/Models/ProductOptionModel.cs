namespace DustysCorner.Client.Models
{
    public class ProductOptionModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public ProductModel Product { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}