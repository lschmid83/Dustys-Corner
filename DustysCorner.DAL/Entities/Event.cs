using DustysCorner.DAL.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DustysCorner.DAL.Entities
{
    [Table("Event")]
    public class Event : EntityBase
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [Required]
        public string Image { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(250)]
        [Required]
        public string Location { get; set; }

        [MaxLength(250)]
        [Required]
        public string Url { get; set; }

        [MaxLength(250)]
        [Required]
        public string Twitter { get; set; }
    }
}
