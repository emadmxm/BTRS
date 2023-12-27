using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BTRS.Models
{
    public class Bus
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public string CaptainName { get; set; }

        [Required(ErrorMessage = "Must be insert")]
        public int Seats { get; set; }



        [ForeignKey("BusTripID")]
        public BusTrip busTrip { get; set; }
    }
}
