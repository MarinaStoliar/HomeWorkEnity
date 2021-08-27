using HomeWorkEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEntity
{
    public class HomeContextFactory : IDesignTimeDbContextFactory<HomeDbContext>
    {
        public HomeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HomeDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Home;Integrated Security=True;");
            return new HomeDbContext(optionsBuilder.Options);
        }
    }
}
