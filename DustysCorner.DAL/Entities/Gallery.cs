using DustysCorner.DAL.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("Gallery")]
    public class Gallery : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [Required]
        public string Image { get; set; }       

        [MaxLength(250)]
        public string ImageTitle { get; set; } = string.Empty;
        
        public virtual ICollection<GalleryImage> AdditionalImages { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }

        [Required]
        public int Order { get; set; }

    }
}
