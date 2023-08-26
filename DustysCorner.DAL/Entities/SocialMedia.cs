using DustysCorner.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("SocialMedia")]
    public class SocialMedia : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Facebook { get; set; }

        [MaxLength(250)]
        [Required]
        public string Twitter { get; set; }
               
        [MaxLength(250)]
        [Required]
        public string TwitterEmbed { get; set; }
    }
}
