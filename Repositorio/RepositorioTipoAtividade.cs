﻿using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contratos;

namespace Repositorio
{
    public class RepositorioTipoAtividade : IRepositorioTipoAtividade
    {
        private readonly IContexto _contexto;

        public RepositorioTipoAtividade(IContexto contexto)
        {
            _contexto = contexto;
        }

        public List<TipoAtividade>? BuscarAtividades()
        {
            return _contexto.TiposAtividade?.ToList();
        }

        public void AddAtividade(TipoAtividade tipoAtividade)
        {

            _contexto.TiposAtividade?.Add(tipoAtividade);

        }

        public void ApagarAtividade(int codigoTipoAtividade)
        {
            var atividade = _contexto.TiposAtividade?.FirstOrDefault(atv => atv.TipoAtividadeId == codigoTipoAtividade);
            if (atividade != null)
            {
                _contexto.TiposAtividade?.Remove(atividade);
            }
        }

        public void AtualizarAtividade(int codigoTipoAtividade, TipoAtividade novoTipoAtividade)
        {
            var atividade = _contexto.TiposAtividade?.FirstOrDefault(atv => atv.TipoAtividadeId == codigoTipoAtividade);
            if (atividade != null)
            {
                _contexto.AtualizarEntity(atividade, novoTipoAtividade);
            }

        }

        public TipoAtividade? BuscarTipoAtividadePorCodigo(int codigoTipoAtividade)
        {
            return _contexto.TiposAtividade?.FirstOrDefault(atv => atv.TipoAtividadeId == codigoTipoAtividade);

        }
    }
}
