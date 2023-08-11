using System.ComponentModel.DataAnnotations;

namespace CarWebApi.Entity
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required, MaxLength(30)]
        public double Price { get; set; }
        [Required]
        public string DateTime { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Probek { get; set; }
    }
}
