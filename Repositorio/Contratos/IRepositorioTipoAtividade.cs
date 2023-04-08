using Entidade;

namespace Repositorio.Contratos
{
    public interface IRepositorioTipoAtividade
    {
        void AddAtividade(TipoAtividade tipoAtividade);
        void ApagarAtividade(int codigoTipoAtividade);
        void AtualizarAtividade(int codigoTipoAtividade, TipoAtividade novoTipoAtividade);
        List<TipoAtividade>? BuscarAtividades();
        TipoAtividade? BuscarTipoAtividadePorCodigo(int codigoTipoAtividade);
    }
}