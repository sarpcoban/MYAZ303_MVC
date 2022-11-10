using Microsoft.EntityFrameworkCore;
using MYAZ303_MVC.Models;

namespace MYAZ303_MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


        public DbSet<Sarki> Sarkilar { get; set; }
    }   
}
