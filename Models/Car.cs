using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDotNetCoreFake.Models
{
    [Table("Cars")]
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
    }
}
