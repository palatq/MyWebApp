using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Items.Data // Замените на ваше пространство имен
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
