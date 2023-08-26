using DustysCorner.Client.Models;
using System.Collections.Generic;

namespace DustysCorner.MVC.Models
{
    public class BaseViewModel
    {
        public IEnumerable<CategoryModel> Categories { get; set; }

        public SocialMediaModel SocialMedia { get; set; }

        public EventModel Event { get; set; }
    }
}
