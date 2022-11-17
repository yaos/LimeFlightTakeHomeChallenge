using LimeFlightTakeHomeChallenge.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace LimeFlightTakeHomeChallenge.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=AppDbContext;User=sa;Password=1Secure*Password1;MultipleActiveResultSets=True;Connection Timeout=30;Encrypt=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Flight Seed
            var today = DateTime.Now;
            modelBuilder.Entity<Flight>().HasData(
                   new Flight()
                   {
                       Id = 1,
                       ExternalId = "201",
                       Carrier = "LimeAir",
                       Flightnumber = 1075,
                       OperationalSuffix = "P",
                       Codeshare = "",
                       Dep = "ZRH",
                       Dest = "FRA",
                       DepEff = "ZRH",
                       DepGateEff = "D34",
                       DestEff = "FRA",
                       DestGateEff = "C3",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddHours(18).AddMinutes(00),
                       Sta = today.AddHours(19).AddMinutes(10),
                       StdLt = today.AddHours(19).AddMinutes(00),
                       StaLt = today.AddHours(20).AddMinutes(10),
                       AcRegistration = "ZH-IJU",
                       AcType = "320",
                       RotationNumber = "ZRH-FRA-ZRH",
                       LineOfWork = "LineOfWork1",
                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,
                       TotEff = today.AddHours(18).AddMinutes(00),
                       TotLtEff = today.AddHours(19).AddMinutes(10),
                       LdtEff = today.AddHours(19).AddMinutes(00),
                       LdtLtEff = today.AddHours(20).AddMinutes(10),
                       StaEff = today.AddHours(18).AddMinutes(00),
                       StaLtEff = today.AddHours(19).AddMinutes(10),
                       StdEff = today.AddHours(19).AddMinutes(00),
                       StdLtEff = today.AddHours(20).AddMinutes(10),
                   },
                   new Flight
                   {
                       Id = 2,
                       ExternalId = "202",
                       Carrier = "limeair",
                       Flightnumber = 1076,
                       Codeshare = null,
                       Dep = "FRA",
                       Dest = "ZRH",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddHours(18).AddMinutes(30),
                       Sta = today.AddHours(19).AddMinutes(40),
                       StdLt = today.AddHours(19).AddMinutes(30),
                       StaLt = today.AddHours(20).AddMinutes(40),
                       AcRegistration = "ZH-IJU",
                       AcType = "320",
                       RotationNumber = "ZRH-FRA-ZRH",

                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,
                   },
                   new Flight
                   {
                       Id = 3,
                       ExternalId = "203",
                       Carrier = "limeair",
                       Flightnumber = 1077,
                       Codeshare = "",
                       Dep = "ZRH",
                       Dest = "FRA",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddHours(19).AddMinutes(00),
                       Sta = today.AddHours(20).AddMinutes(20),
                       StdLt = today.AddHours(21).AddMinutes(00),
                       StaLt = today.AddHours(22).AddMinutes(20),
                       AcRegistration = "ZH-IJU",
                       AcType = "320",
                       RotationNumber = "ZRH-FRA-ZRH",

                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 4,
                       ExternalId = "206",
                       Carrier = "limeair",
                       Flightnumber = 1078,
                       OperationalSuffix = "P",
                       Codeshare = "",
                       Dep = "JFK",
                       Dest = "CDG",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddHours(12).AddMinutes(00),
                       Sta = today.AddHours(23).AddMinutes(20),
                       StdLt = today.AddHours(11).AddMinutes(00),
                       StaLt = today.AddHours(22).AddMinutes(20),
                       AcRegistration = "ZH-JHQ",
                       AcType = "320",
                       RotationNumber = "JDK-CDG-YYZ-SFO-JFK",

                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 5,
                       ExternalId = "247",
                       Carrier = "limeair",
                       Flightnumber = 3598,
                       Codeshare = "",
                       RotationNumber = "MUC-FRA-MUC",
                       Dep = "MUC",
                       Dest = "FRA",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddHours(18).AddMinutes(00),
                       Sta = today.AddHours(19).AddMinutes(10),
                       StdLt = today.AddHours(19).AddMinutes(00),
                       StaLt = today.AddHours(20).AddMinutes(10),
                       AcRegistration = "ZH-IJU",
                       AcType = "777",
                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 6,
                       ExternalId = "444",
                       Carrier = "limeair",
                       Flightnumber = 3556,
                       Codeshare = "",
                       Dep = "CDG",
                       Dest = "YYZ",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddDays(1).AddHours(6).AddMinutes(00),
                       Sta = today.AddDays(1).AddHours(17).AddMinutes(20),
                       StdLt = today.AddDays(1).AddHours(5).AddMinutes(00),
                       StaLt = today.AddDays(1).AddHours(16).AddMinutes(20),
                       AcRegistration = "ZH-JHQ",
                       AcType = "320",
                       RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 7,
                       ExternalId = "555",
                       Carrier = "limeair",
                       Flightnumber = 4586,
                       Codeshare = "",
                       Dep = "YYZ",
                       Dest = "SFO",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddDays(2).AddHours(6).AddMinutes(00),
                       Sta = today.AddDays(2).AddHours(15).AddMinutes(20),
                       StdLt = today.AddDays(2).AddHours(5).AddMinutes(00),
                       StaLt = today.AddDays(2).AddHours(14).AddMinutes(20),
                       AcRegistration = "ZH-JHQ",
                       AcType = "320",
                       RotationNumber = "JDK-CDG-YYZ-SFO-JFK",

                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 8,
                       ExternalId = "556",
                       Carrier = "limeair",
                       Flightnumber = 4587,
                       Codeshare = "",
                       Dep = "SFO",
                       Dest = "JFK",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddDays(2).AddHours(17).AddMinutes(00),
                       Sta = today.AddDays(2).AddHours(23).AddMinutes(20),
                       StdLt = today.AddDays(2).AddHours(16).AddMinutes(00),
                       StaLt = today.AddDays(2).AddHours(22).AddMinutes(20),
                       AcRegistration = "ZH-JHQ",
                       AcType = "320",
                       RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,

                   },
                   new Flight
                   {
                       Id = 9,
                       ExternalId = "557",
                       Carrier = "limeair",
                       Flightnumber = 4900,
                       Codeshare = "",
                       Dep = "JFK",
                       Dest = "CDG",
                       CreatedDate = today,
                       FkCreatedBy = "info@limeair.ch",
                       Std = today.AddDays(3).AddHours(18).AddMinutes(00),
                       Sta = today.AddDays(4).AddHours(6).AddMinutes(30),
                       StdLt = today.AddDays(3).AddHours(17).AddMinutes(00),
                       StaLt = today.AddDays(4).AddHours(5).AddMinutes(20),
                       AcRegistration = "ZH-JHQ",
                       AcType = "320",
                       RotationNumber = "JDK-CDG-YYZ-SFO-JFK",
                       Owner = "limeair",
                       Remarks = "REFER TO limeair MEALPLAN",
                       Tow = null,
                       TotEff = today.AddDays(11).AddHours(12).AddMinutes(02),

                   }
               );
            #endregion

        }

        public DbSet<Flight> Flights { get; set; }
    }
}
