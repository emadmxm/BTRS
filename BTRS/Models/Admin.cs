using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string Password { get; set; }


        public string FullName { get; set; }


        public ICollection<BusTrip> busTrips { get; set; }
    }
}
