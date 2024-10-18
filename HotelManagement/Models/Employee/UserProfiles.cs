namespace HotelManagement.Models.Employee
{
    public class UserProfiles
    {
        public int ProfileID { get; set; } // Az egyedi azonosító
        public string FirstName { get; set; } // A dolgozó vezetékneve
        public string LastName { get; set; } // A dolgozó vezetékneve
        public DateTime BirthDate { get; set; } //Születési dátum
        public DateTime JoinDate { get; set; }//Belépési  dátum
        public DateTime ExitDate { get; set; }//Kilépési  dátum
    }
}
