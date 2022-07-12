using System.ComponentModel.DataAnnotations;

namespace SimpleWardrobe.Models
{

    //Called it "Garment" instead of "Clothingitem"/"Clothes" in order to have easy access/name in singular/plural
    public class Garment : IGarments
    {
        [Required]
        public int GarmentId { get; set; }

        public string? UniqueName { get; set; }

        public decimal? Cost { get; set; }
        public GarmentType? GarmentType { get; set; }

        public short? Quantity { get; set; }

        public Garment()
        {

        }
    }
}
