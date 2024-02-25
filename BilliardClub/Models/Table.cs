using System.ComponentModel.DataAnnotations;

namespace BilliardClub.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool IsSmokingAllowed { get; set; }
    }
}
