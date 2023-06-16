using Entidade;

namespace Repositorio.Contratos
{
    public interface IRepositorioAtividadeComplementar
    {
        void AddAtividadeComplementar(AtividadeComplementar atividadeComplementar);
        void ApagarAtividadeComplementar(int codigoAtividadeComplementar);
        void AtualizarAtividadeComplementar(int codigoAtividadeComplementar, AtividadeComplementar novoAtividadeComplementar);
        AtividadeComplementar? BuscarAtividadComplementarPorCodigo(int codigoAtividadeComplementar);
        List<AtividadeComplementar>? BuscarAtividadesComplementar();
    }
}