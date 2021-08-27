using HomeWorkEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HomeWorkEntity
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder.AddJsonFile("appsettings.json");

            var configuration = configurationBuilder.Build();
            var configurationString = configuration.GetConnectionString("HomeConnectionString");
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<HomeDbContext>();

            dbContextOptionsBuilder.UseSqlServer(configurationString);
            dbContextOptionsBuilder.LogTo(Console.WriteLine);

            using (var dbContext = new HomeDbContext(dbContextOptionsBuilder.Options))
            {

                //var architects = dbContext.Architects;

                //foreach (var architect in architects)
                //{
                //    Console.WriteLine($"Id: {architect.Id}, Architect name: {architect.Name}, Level: {architect.Level}");
                //}


                var petro = await dbContext.Architects.SingleAsync(i => i.Name == "Petro");

                //Оновлення
                petro.Level = "Master";

                var denis = await dbContext.Architects.SingleAsync(i => i.Name == "Denis");

                //Видалення
                dbContext.Architects.Remove(denis);

                dbContext.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
