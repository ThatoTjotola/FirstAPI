using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FirstAPI.Models
{
    public class Product
    {
        public int Id { get; set; } 
        
        public string TeamName { get; set; } = string.Empty;
        [Required]
        public string DriverName { get; set; } = string.Empty;
        [Required]
        public string CarDescription { get; set; } = string.Empty;
        public string FastestTime { get; set; }
        public bool Contractvalid { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
