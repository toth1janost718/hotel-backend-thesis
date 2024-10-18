using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models.Employee
{
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileID { get; set; } // Az egyedi azonosító
        [Required]
        [MaxLength(50)]

        public string FirstName { get; set; } // A dolgozó vezetékneve
        [Required]
        [MaxLength(50)]

        public string LastName { get; set; } // A dolgozó vezetékneve
        [Required]        

        public DateTime BirthDate { get; set; } //Születési dátum
        [Required]
        
        public DateTime JoinDate { get; set; }//Belépési  dátum

        public DateTime? ExitDate { get; set; }//Kilépési  dátum


               
        public int RoleId { get; set; }
        [NotMapped]
        public virtual Role Role { get; set; }  // Navigációs property a Role osztályhoz


        public int UserLoginId { get; set; } // Az idegen kulcs a UserLogin táblára

        [NotMapped]
        // Navigációs property a UserLogin-hoz
        public virtual UserLogin UserLogin { get; set; }
    }
}
