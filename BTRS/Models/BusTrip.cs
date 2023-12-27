using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
    public class BusTrip
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Must be insert")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string BusNumber { get; set; }

        [ForeignKey("AdminID")]
        public Admin Admin { get; set; }


        public ICollection<Bus> bus { set; get; }

        public ICollection<Passenger_User> passenger_User { set; get; }
    }
}
