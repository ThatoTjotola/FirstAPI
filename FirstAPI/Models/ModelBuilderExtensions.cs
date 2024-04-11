using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "A Team" },
                new Category { Id = 2, Name = "B Team" },
                new Category { Id = 3, Name = "C Team" },
                new Category { Id = 4, Name = "aii" },
                new Category { Id = 5, Name = "shit team" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, TeamName = "Red Bull Racing", DriverName = "Max Verstappen", FastestTime = "null", Contractvalid = true , CarDescription = "RB20 does retain the downwash sidepod solutions further down, while its nose and other front-end parts appear similar to those Red Bull was running at the end of last season" },
new Product { Id = 2, CategoryId = 1, TeamName = "Red Bull Racing", DriverName = "Sergio Perez", FastestTime = "null", Contractvalid = true , CarDescription = "RB20 does retain the downwash sidepod solutions further down, while its nose and other front-end parts appear similar to those Red Bull was running at the end of last season" },
new Product { Id = 3, CategoryId = 1, TeamName = "McLaren", DriverName = "Lando Norris", FastestTime = "null", Contractvalid = true ,CarDescription = "https://www.the-race.com/formula-1/mclaren-reveals-2024-f1-car-mcl38/" },
new Product { Id = 4, CategoryId = 1, TeamName = "McLaren", DriverName = "Oscar Piastri", FastestTime = "null", Contractvalid = true,CarDescription = "https://www.the-race.com/formula-1/mclaren-reveals-2024-f1-car-mcl38/" },
new Product { Id = 11, CategoryId = 5, TeamName = "Alpine ", DriverName = "Pierre Gasly", FastestTime = "null", Contractvalid = false,CarDescription = "Shit car" },
new Product { Id = 12, CategoryId = 5, TeamName = "Alpine", DriverName = "Esteban Ocon", FastestTime = "null", Contractvalid = true,CarDescription= "Shit car" },
new Product { Id = 13, CategoryId = 3, TeamName = "AlphaTauri", DriverName = "Daniel Riccardo", FastestTime = "null", Contractvalid = true },
new Product { Id = 14, CategoryId = 3, TeamName = "AlphaTauri", DriverName = "Yuki Tsunoda", FastestTime = "null", Contractvalid = true },
new Product { Id = 15, CategoryId = 4, TeamName = "Stake Racing", DriverName = "Valterri Bottas", FastestTime = "null", Contractvalid = true },
new Product { Id = 16, CategoryId = 4, TeamName = "Stake Racing", DriverName = "Zhou Guanyu", FastestTime = "null", Contractvalid = true },
new Product { Id = 17, CategoryId = 3, TeamName = "Haas", DriverName = "Kevin Mangussen", FastestTime = "null", Contractvalid = true },
new Product { Id = 18, CategoryId = 3, TeamName = "Haas", DriverName = "Niko Hulkenberg", FastestTime = "null", Contractvalid = true },
new Product { Id = 19, CategoryId = 3, TeamName = "Williams", DriverName = "Alex Albon", FastestTime = "null", Contractvalid = true },
new Product { Id = 20, CategoryId = 3, TeamName = "Williams", DriverName = "Logan Sergaant", FastestTime = "null", Contractvalid = true },
new Product { Id = 22, CategoryId = 1, TeamName = "Scuderia Ferrari", DriverName = "Charles Leclerc", FastestTime = "", Contractvalid = true },
new Product { Id = 23, CategoryId = 1, TeamName = "Scuderia Ferrari", DriverName = "Carlos Sainz", FastestTime = "1:20:26.843", Contractvalid = true },
new Product { Id = 25, CategoryId = 4, TeamName = "Mercedes-AMG Petronas Formula One Team", DriverName = "Lewis Hamilton", FastestTime = "null", Contractvalid = true },
new Product { Id = 26, CategoryId = 4, TeamName = "Mercedes-AMG Petronas Formula One Team", DriverName = "George Russell", FastestTime = "null", Contractvalid = true },
new Product { Id = 27, CategoryId = 2, TeamName = "Aston Martin Cognizant Formula One™ Team", DriverName = "Fernando Alonso", FastestTime = "null", Contractvalid = true },
new Product { Id = 28, CategoryId = 2, TeamName = "Aston Martin Cognizant Formula One™ Team", DriverName = "Lance Stroll", FastestTime = "null", Contractvalid = true },
new Product { Id = 31, CategoryId = 3, TeamName = "AlphaTauri Honda", DriverName = "Daniel Riccardo", FastestTime = "null", Contractvalid = true },
new Product { Id = 32, CategoryId = 3, TeamName = "AlphaTauri Honda", DriverName = "Yuki Tsunoda", FastestTime = "null", Contractvalid = true });
        }

    }
}
 