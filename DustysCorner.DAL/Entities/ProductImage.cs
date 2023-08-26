using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("ProductImage")]
    public class ProductImage : EntityBase
    {
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int Order { get; set; }

    }
}