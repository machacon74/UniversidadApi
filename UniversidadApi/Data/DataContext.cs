global using Microsoft.EntityFrameworkCore;
using UniversidadApi.Models;

namespace UniversidadApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("workstation id=UNIVERSIDAD.mssql.somee.com;packet size=4096;user id=JESUS_MACHACON;pwd=jesusmachacon_SQLLogin_1\t;data source=UNIVERSIDAD.mssql.somee.com;persist security info=False;initial catalog=UNIVERSIDAD");
        }

        public DbSet<Genero> Generos { get; set; }
    }
}
