using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("GalleryImage")]
    public class GalleryImage : EntityBase
    {
        [Required]
        public int GalleryId { get; set; }

        [ForeignKey("GalleryId")]
        public virtual Gallery Gallery { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int Order { get; set; }

    }
}
