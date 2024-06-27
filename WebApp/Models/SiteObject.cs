using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    [Table("SiteObjectList")]
    public class SiteObject
    {
        [Key]
        public int SiteObjectId { get; set; }

        [Required]
        public string SiteObjectName { get; set; } = ""!;

        [Required]
        public string Path { get; set; } = ""!;

        [Required]
        public int TypeId { get; set; }

        [Required]
        public string TypeName { get; set; } = ""!;

        [Required]
        public string Icon { get; set; } = ""!;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = ""!;
    }
}
