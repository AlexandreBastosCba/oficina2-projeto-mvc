using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contratos;

namespace Repositorio
{
    public class RepositorioAtividadeComplementar : IRepositorioAtividadeComplementar
    {
        private readonly IContexto _contexto;

        public RepositorioAtividadeComplementar(IContexto contexto)
        {
            _contexto = contexto;
        }

        public List<AtividadeComplementar>? BuscarAtividadesComplementar()
        {
            return _contexto.AtividadesComplementar?.Include(atividade=>atividade.TipoAtividade).Include(atividade=>atividade.Aluno).ToList();
        }

        public void AddAtividadeComplementar(AtividadeComplementar atividadeComplementar)
        {

            _contexto.AtividadesComplementar?.Add(atividadeComplementar);

        }

        public void ApagarAtividadeComplementar(int codigoAtividadeComplementar)
        {
            var atividadeComplementar = _contexto.AtividadesComplementar?.FirstOrDefault(atv => atv.AtividadeComplementarId == codigoAtividadeComplementar);
            if (atividadeComplementar != null)
            {
                _contexto.AtividadesComplementar?.Remove(atividadeComplementar);
            }
        }

        public void AtualizarAtividadeComplementar(int codigoAtividadeComplementar, AtividadeComplementar novoAtividadeComplementar)
        {
            var atividadeComplementar = _contexto.AtividadesComplementar?.FirstOrDefault(atv => atv.AtividadeComplementarId == codigoAtividadeComplementar);
            if (atividadeComplementar != null)
            {
                _contexto.AtualizarEntity(atividadeComplementar, novoAtividadeComplementar);
            }

        }

        public AtividadeComplementar? BuscarAtividadComplementarPorCodigo(int codigoAtividadeComplementar)
        {
            return _contexto.AtividadesComplementar?.FirstOrDefault(atv => atv.AtividadeComplementarId == codigoAtividadeComplementar);

        }
    }
}
