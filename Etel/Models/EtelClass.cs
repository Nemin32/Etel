using System.ComponentModel.DataAnnotations;

namespace Etel.Models
{
    public class EtelClass
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Nev { get; set; }
        [Required]
        public int Tapertek { get; set; }
        
        [Required]
        public string Kategoria { get; set; }
        [Required]
        public int Ar { get; set; }
        public string? ContentType { get; set; }
        public byte[]? Data { get; set; }

        public EtelClass()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
