using Aluguel.Models;
using Microsoft.EntityFrameworkCore;


namespace Aluguel.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        
        }


        public DbSet<EmprestimoModels> Emprestimos { get; set; }

    }
}
