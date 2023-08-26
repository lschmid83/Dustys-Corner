using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("ProductOption")]
    public class ProductOption : EntityBase
    {
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Order { get; set; }
    }
}