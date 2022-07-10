using System.ComponentModel.DataAnnotations;

namespace SimpleWardrobe.Models
{
    public class Shoe : IGarments
    {
        [Required]
        public int Id { get; set; }

        public string? UniqueName { get; set; }

        public decimal? Cost { get; set; }
        public ShoeTypes? ShoeType { get; set; }

        public short? Quantity { get; set; }

        public IEnumerable<Seasons>? SeasonsAppropiate { get; set; }
        public IEnumerable<Weather>? WeatherAppropiate { get; set; }
        public IEnumerable<Style>? Style { get; set; }

        public Shoe()
        {
             
        }
    }
}
