using DustysCorner.Client.Models;
using System.Collections.Generic;

namespace DustysCorner.MVC.Models
{
    public class HomeViewModel : BaseViewModel
    {
        public IEnumerable<ProductModel> FeaturedProducts { get; set; }
        public IEnumerable<ReviewModel> CustomerReviews { get; set; }
    }
}
