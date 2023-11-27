using Microsoft.EntityFrameworkCore;
using PracticeApp.Models;

namespace PracticeApp.Data
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext> options) 
            : base(options) 
        { 

        }

        public DbSet<A> As {  get; set; }
    }
}
