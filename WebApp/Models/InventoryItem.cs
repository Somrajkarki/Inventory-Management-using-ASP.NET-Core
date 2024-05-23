using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class InventoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? ItemName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Model { get; set; }

        [Column(TypeName = "int(100)")]
        public int? QuantityInStock { get; set; }

        [Column(TypeName = "int(100)")]
        public int? TotalQuantity { get; set; }
    }
}
