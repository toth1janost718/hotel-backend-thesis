using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models.Employee
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; } // Az egyedi azonosító

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; } // A szerepkör neve


        // Navigációs property, ami lehetővé teszi a kapcsolatot a UserProfile osztállyal

        [NotMapped]

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
