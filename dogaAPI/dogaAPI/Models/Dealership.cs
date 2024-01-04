using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dogaAPI.Models
{
    public class Dealership
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Address { get; set; }
        public Guid CarsId { get; set; }
        public Cars Cars { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
