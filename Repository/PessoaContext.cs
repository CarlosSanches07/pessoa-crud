using Microsoft.EntityFrameworkCore;
using pessoa_crud.Domain;

namespace pessoa_crud.Repository {
    public class PessoaContext : DbContext {
        public DbSet<Pessoa> Pessoas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("FileName=PessoaCrudDb.db");
    }
}