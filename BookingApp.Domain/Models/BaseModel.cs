namespace BookingApp.Domain.Models
{
    public class BaseModel
    {
        public string CreateBy { get; set; } = string.Empty;
        public DateTime? CreateDate { get; set; }
        public DateTime? Update { get; set; }
        public DateTime? UpdateBy { get; set; }
    }
}
