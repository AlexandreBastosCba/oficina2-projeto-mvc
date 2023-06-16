using Entidade;

namespace Repositorio.Contratos
{
    public interface IRepositorioAluno
    {
        void AddAluno(Aluno aluno);
        void ApagarAluno(int codigoaluno);
        void AtualizarAluno(int codigoaluno, Aluno novoaluno);
        List<Aluno>? BuscarAluno();
        Aluno? BuscarAlunoPorCodigo(int codigoaluno);
    }
}