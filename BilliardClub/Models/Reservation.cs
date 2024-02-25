using System.ComponentModel.DataAnnotations;

namespace BilliardClub.Models
{
    public class Reservation
    {
        [Key]
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int TableId { get; set; }
        public string Description { get; set; }
    }
}
