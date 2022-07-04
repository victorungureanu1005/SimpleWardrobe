using System.ComponentModel.DataAnnotations;

namespace SimpleWardrobe.Models
{

    //Called it "Garment" instead of "Clothingitem"/"Clothes" in order to have easy access/name in singular/plural
    public class Garment : IGarments
    {
        [Required]
        public int Id { get; set; }

        public string? UniqueName { get; set; }

        public decimal? Cost { get; set; }
        public GarmentTypes? GarmentType { get; set; }

        public short? Quantity { get; set; }

        public IEnumerable<Seasons>? SeasonsAppropiate { get; set; }
        public IEnumerable<Weather>? WeatherAppropiate { get; set; }
        public IEnumerable<Style>? Style { get; set; }

        public Garment()
        {

        }
    }
}
