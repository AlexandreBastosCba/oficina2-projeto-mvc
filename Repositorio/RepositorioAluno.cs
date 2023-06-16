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
    public class RepositorioAluno : IRepositorioAluno
    {
        private readonly IContexto _contexto;

        public RepositorioAluno(IContexto contexto)
        {
            _contexto = contexto;
        }

        public List<Aluno>? BuscarAluno()
        {
            return _contexto.Aluno?.ToList();
        }

        public void AddAluno(Aluno aluno)
        {

            _contexto.Aluno?.Add(aluno);

        }

        public void ApagarAluno(int codigoaluno)
        {
            var aluno = _contexto.Aluno?.FirstOrDefault(atv => atv.AlunoId == codigoaluno);
            if (aluno != null)
            {
                _contexto.Aluno?.Remove(aluno);
            }
        }

        public void AtualizarAluno(int codigoaluno, Aluno novoaluno)
        {
            var aluno = _contexto.Aluno?.FirstOrDefault(atv => atv.AlunoId == codigoaluno);
            if (aluno != null)
            {
                _contexto.AtualizarEntity(aluno, novoaluno);
            }

        }

        public Aluno? BuscarAlunoPorCodigo(int codigoaluno)
        {
            return _contexto.Aluno?.FirstOrDefault(atv => atv.AlunoId == codigoaluno);

        }
    }
}
