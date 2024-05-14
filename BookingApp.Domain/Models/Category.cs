using System.ComponentModel.DataAnnotations;

namespace BookingApp.Domain.Models
{
    public class Category : BaseModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;
    }
}
