using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using DustysCorner.DAL.Entities.Base;

namespace DustysCorner.DAL.Entities
{
    [Table("Category")]
    public class Category : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Order { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Children { get; set; }

        [MaxLength(250)]
        [Required]
        public string Route { get; set; }
    }
}