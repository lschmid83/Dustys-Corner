using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("Review")]
    public class Review : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [Required]
        public string Image { get; set; }
        
        [MaxLength(250)]
        [Required]
        public string Text { get; set; }
    }
}
