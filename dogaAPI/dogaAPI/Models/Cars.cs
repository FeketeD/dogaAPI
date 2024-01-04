using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dogaAPI.Models
{
    public class Cars
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Brand { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Model { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
