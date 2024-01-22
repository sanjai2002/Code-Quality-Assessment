namespace CreateApi.Data;
using Microsoft.EntityFrameworkCore;
public class Appdbcontext:DbContext{
    public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
    {
        
    }
    public DbSet<MovieModel> Moviedetails{get; set;}
    
}
