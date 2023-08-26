using DustysCorner.Client.Models;
using System.Collections.Generic;

namespace DustysCorner.MVC.Models
{
    public class GalleryViewModel : BaseViewModel
    {
        public CategoryModel Category { get; set; }
        public IEnumerable<GalleryModel> Gallery { get; set; }
    }
}
