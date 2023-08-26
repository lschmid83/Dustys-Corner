using DustysCorner.DAL.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("Product")]
    public class Product : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(5000)]
        [Required]
        public string Description { get; set; }

        [MaxLength(250)]
        [Required]
        public string Image { get; set; }

        [MaxLength(250)]
        public string ImageTitle { get; set; } = string.Empty;

        [MaxLength(250)]
        [Required]
        public string Thumbnail { get; set; }

        public virtual ICollection<ProductImage> AdditionalImages { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public bool LimitedStock { get; set; }
        
        public virtual List<ProductOption> Options { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
    }
}
