using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
    public class Passenger
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string Gender { get; set; }

        public ICollection<Passenger_User> passenger_User { get; set; }
    }
}
