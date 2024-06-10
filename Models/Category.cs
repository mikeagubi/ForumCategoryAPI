using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CategoryAPI.Models
{
    public class Category
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        
        [JsonPropertyName("Name")]
        [Required]
        [Display(Name ="Kategorinamn")]
        public string Name { get; set; }
    }
}
