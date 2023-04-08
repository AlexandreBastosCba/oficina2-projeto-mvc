using Entidade;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contratos;

namespace Repositorio
{
    public class Contexto : DbContext, IContexto
    {
        public DbSet<TipoAtividade>? TiposAtividade { get; set; }
        public DbSet<Aluno>? Alunos { get; set; }
        public DbSet<AtividadeComplementar>? AtividadesComplementar { get; set; }

        public void AtualizarEntity<T>(T entidade, T novaEntidade)
        {
            if ((entidade != null) && (novaEntidade != null))
                Entry(entidade).CurrentValues.SetValues(novaEntidade);
        }

        public void Salvar()
        {
            SaveChanges();
        }

        public Contexto(DbContextOptions options): base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
    }
}