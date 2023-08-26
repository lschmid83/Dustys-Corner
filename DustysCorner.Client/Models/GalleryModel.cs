using System.Collections.Generic;

namespace DustysCorner.Client.Models
{
    public class GalleryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string ImageTitle { get; set; } = string.Empty;

        public virtual IEnumerable<GalleryImageModel> AdditionalImages { get; set; }

        public string Blog { get; set; } = string.Empty;

        public string YouTube { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public CategoryModel Category { get; set; }

        public int Order { get; set; }

    }
}
