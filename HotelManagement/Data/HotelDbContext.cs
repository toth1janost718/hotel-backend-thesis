using HotelManagement.Models.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HotelManagement.Data
{
    public class HotelDbContext : DbContext
    {
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }



        private readonly IConfiguration _configuration;

        public HotelDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("AzureDbConnection");
            optionsBuilder.UseSqlServer(connectionString, options =>
        options.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
                         .HasOne(u => u.Role) 
                          .WithMany(r => r.UserProfiles) 
                          .HasForeignKey(u => u.RoleId) 
                           .OnDelete(DeleteBehavior.Restrict); 

            
            modelBuilder.Entity<UserProfile>()
                .HasOne(u => u.UserLogin) 
                .WithOne(ul => ul.UserProfile) 
                .HasForeignKey<UserProfile>(u => u.UserLoginId) 
                .OnDelete(DeleteBehavior.Cascade);

        }

    }

    
}
