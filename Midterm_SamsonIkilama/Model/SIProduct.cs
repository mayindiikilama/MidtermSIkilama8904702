using System.ComponentModel.DataAnnotations;

namespace Midterm_SamsonIkilama.Model
{
    public class SIProduct
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; } = null!;


        [Required]
        [StringLength(25)]
        public int Quantity { get; set; }
    }
}
