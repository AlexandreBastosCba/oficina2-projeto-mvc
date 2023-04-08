using Entidade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Contratos
{
    public interface IContexto
    {
        DbSet<TipoAtividade>? TiposAtividade { get; set; }
        DbSet<Aluno>? Alunos { get; set; }
        DbSet<AtividadeComplementar>? AtividadesComplementar { get; set; }
        void Salvar();
        void AtualizarEntity<T>(T entidade, T novaEntidade);
    }
}
