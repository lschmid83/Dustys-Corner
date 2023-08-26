using DustysCorner.Client.Models;
using System.Collections.Generic;

namespace DustysCorner.MVC.Models
{
    public class ShopViewModel : BaseViewModel
    {
        public CategoryModel Category { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
    }
}
