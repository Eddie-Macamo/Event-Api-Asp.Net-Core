using System.ComponentModel.DataAnnotations;

namespace Events_WebApiApplication.Models
{
    public class EventDto
    {
        [Required]
        public string Title { get; set; } = "";

        [MaxLength(500)]
        public string Description { get; set; } = "";

        [Required]
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public bool Allday { get; set; }
    }
}
