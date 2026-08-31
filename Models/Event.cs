using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Event
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Venue { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
