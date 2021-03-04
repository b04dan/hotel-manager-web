using HotelManager.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.DAL.EF
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<WeeklySchedule> Schedules { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPT подход к маппингу иерархии класса
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Worker>().ToTable("Workers");


          
            #region Clients

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Residences)
                .WithOne(r => r.Client)
                .IsRequired();

            #endregion

            #region HotelRooms

            modelBuilder.Entity<HotelRoom>()
                .HasMany(r => r.Residences)
                .WithOne(r => r.HotelRoom)
                .IsRequired();

            #endregion

            #region Hotels

            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.HotelRooms)
                .WithOne(r => r.Hotel)
                .IsRequired();

            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Workers)
                .WithOne(r => r.Hotel)
                .IsRequired();
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}