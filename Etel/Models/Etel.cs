using System.ComponentModel.DataAnnotations;

namespace Etel.Models
{
    public class Etel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        string Nev { get; set; }
        [Required]
        int Tapertek { get; set; }
        
        [Required]
        string Kategoria { get; set; }
        [Required]
        int Ar { get; set; }
        public string? ContentType { get; set; }
        public byte[]? Data { get; set; }

        public Etel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
