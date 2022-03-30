using Microsoft.EntityFrameworkCore;
using mvc_locations.Models;

namespace mvc_locations.Data
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Zadatak:
        // kreirati metodu OnModelCreating(ModelBuilder modelBuilder)
        // Napraviti seed podataka za:
        // Minimalno dvije nasumične države s pripadajućim podacima
        // minimalno šest nasumičnih gradova s pripadajućim podacima

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    id = 1,
                    country_name = "Danska",
                    country_name_eng =  "Denmark",
                    country_code = "+45"
                },
                new Country
                {
                    id = 2,
                    country_name = "Španjolska",
                    country_name_eng = "Spian",
                    country_code = "+34"
                }
            );


            modelBuilder.Entity<City>().HasData(
                new City
                {
                    id = 1,
                    city_name = "Kopenhagen",
                    country_id = 1,
                    latitude = 55.672520m,
                    longitude = 12.563413m

                },
                new City
                {
                    id = 2,
                    city_name = "Holstebro",
                    country_id = 1,
                    latitude = 56.362564m,
                    longitude = 8.621231m
                },
                new City
                {
                    id = 3,
                    city_name = "Kolding",
                    country_id = 1,
                    latitude = 55.495972m,
                    longitude = 9.473052m
                },
                new City
                {
                    id = 4,
                    city_name = "Madrid",
                    country_id = 2,
                    latitude = 40.416775m,
                    longitude = -3.703790m
                },
                new City
                {
                    id = 5,
                    city_name = "Barcelona",
                    country_id = 2,
                    latitude = 41.346176m,
                    longitude = 2.168365m
                },
                new City
                {
                    id = 6,
                    city_name = "Sevilla",
                    country_id = 2,
                    latitude = 37.392529m,
                    longitude = -5.994072m
                }

            );
        }






    }
}
