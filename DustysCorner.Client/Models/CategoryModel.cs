using System.Collections.Generic;

namespace DustysCorner.Client.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Order { get; set; }

        public int? ParentId { get; set; }

        public CategoryModel Parent { get; set; }

        public List<CategoryModel> Children { get; set; }

        public string Route { get; set; }
    }
}