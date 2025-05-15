using Microsoft.EntityFrameworkCore;


namespace BIBLIOTECA.App
{
    public class LivrosContext : DbContext
    {
        public LivrosContext(DbContextOptions<LivrosContext> options) : base(options) { }

        public DbSet<LIVRO> Livros { get; set; }
    }
}

