using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseAndORM.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage ="First Name must be between 3 to 25 characters", MinimumLength = 3)]
       
        public string FirstName { get; set; }


        [Required]
        [StringLength(25, ErrorMessage = "First Name must be between 3 to 25 characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public Client() { }

    }
}
