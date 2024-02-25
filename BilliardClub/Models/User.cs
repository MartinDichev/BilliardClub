﻿using System.ComponentModel.DataAnnotations;

namespace BilliardClub.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
