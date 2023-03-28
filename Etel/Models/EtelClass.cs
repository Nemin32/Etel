using System.ComponentModel.DataAnnotations;

namespace Etel.Models
{
    public class EtelClass
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

        public EtelClass()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
