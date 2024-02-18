namespace BilliardClub.Models
{
    public class Reservation
    {
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int TableId { get; set; }
        public string Description { get; set; }
    }
}
