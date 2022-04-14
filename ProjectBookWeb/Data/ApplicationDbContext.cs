using Microsoft.EntityFrameworkCore;
using ProjectBookWeb.Models;

namespace ProjectBookWeb.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
    {

    }

    
    public DbSet<Category>Categories { get; set; }
}

