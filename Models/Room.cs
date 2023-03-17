using AdvancedDatabaseAndORM.Data;
using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseAndORM.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }

        [Required]
        [Range(1, 6)]
        public int Capacity { get; set; }

        
        public Section Section { get; set; }

        public Room() { }
    }
}
