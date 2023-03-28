using System.ComponentModel.DataAnnotations;

namespace Etel.Models
{
    public enum EtelTipus
    {
        [Display(Name = "Reggeli")]
        Reggeli,
        [Display(Name = "Ebéd")]
        Ebed,
        [Display(Name = "Vacsora")]
        Vacsora
    }

    public class EtelClass
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nev { get; set; }
        [Required]
        [Range(10, 1000)]
        public int Tapertek { get; set; }
        
        [Required]
        public string Kategoria { get; set; }
        [Required]
        [Range(100, 700)]
        public int Ar { get; set; }
        public string? ContentType { get; set; }
        public byte[]? Data { get; set; }

        public EtelClass()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
