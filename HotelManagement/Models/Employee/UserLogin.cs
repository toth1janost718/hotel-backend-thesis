using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models.Employee
{
    public class UserLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; } // Az egyedi azonosító a userhez

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } // Felhasználónév 

        [Required]
        [MaxLength(50)]
        public string Password { get; set; } // Jelszó 

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } // E-mail 

        // Idegen kulcs a UserProfile-hoz
        public int ProfileID { get; set; }

        [NotMapped]
        public virtual UserProfile UserProfile { get; set; } // Navigációs property

    }
}
