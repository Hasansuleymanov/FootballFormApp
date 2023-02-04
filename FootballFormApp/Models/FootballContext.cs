using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class FootballContext : DbContext
    {
        public FootballContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9HU6DH7\\MSSQLSERVER01;DataBase=FootballDB;Trusted_Connection=true;TrustServerCertificate=True");
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reserve>Reserves { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Stadium> Stadiums { get; set;}
        public DbSet<ReserveToClient> ReservToClients { get; set;}
        public DbSet<ReserveToRoom> ReservToRooms { get; set;}
        public DbSet<ReserveToSchedule> ReserveToSchedules { get; set; }
        public DbSet<ReserveToStadium>ReserveToStadiums { get; set; }

    }
}
