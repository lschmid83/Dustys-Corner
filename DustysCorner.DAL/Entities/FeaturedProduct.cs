using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("FeaturedProduct")]
    public class FeaturedProduct : EntityBase
    {
        [Required]
        public int ProductId { get; set; }
        
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        [Required]
        public int Order { get; set; }
    }
}
