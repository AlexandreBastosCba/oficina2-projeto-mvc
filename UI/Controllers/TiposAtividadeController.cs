using Entidade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorio;
using Repositorio.Contratos;
using UI.Models;

namespace UI.Controllers
{
    public class TiposAtividadeController : Controller
    {

        private readonly IContexto _contexto;
        private readonly IRepositorioTipoAtividade _repositorioTipoAtividade;

        public TiposAtividadeController(DbContextOptions dbcontext)
        {

            _contexto = new Contexto(dbcontext);
            _repositorioTipoAtividade = new RepositorioTipoAtividade(_contexto);

        }
        // GET: TiposAtividadeController
        public ActionResult Index()
        {

            //var tipoatividade = _repositorioTipoAtividade.BuscarAtividades()?.Select(tipoAtividade => new TipoAtividadeView
            //{
            //    Codigo = tipoAtividade.TipoAtividadeId,
            //    Descricao = tipoAtividade.Descricao,
            //});
            return View(_repositorioTipoAtividade.BuscarAtividades());
        }

        // GET: TiposAtividadeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TiposAtividadeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposAtividadeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoAtividade tipoAtividade)
        {
            try
            {
                _repositorioTipoAtividade.AddAtividade(tipoAtividade);
                _contexto.Salvar();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposAtividadeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repositorioTipoAtividade.BuscarTipoAtividadePorCodigo(id));
        }

        // POST: TiposAtividadeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoAtividade tipoAtividade)
        {
            try
            {
                _repositorioTipoAtividade.AtualizarAtividade(tipoAtividade.TipoAtividadeId,tipoAtividade);
                _contexto.Salvar();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposAtividadeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repositorioTipoAtividade.BuscarTipoAtividadePorCodigo(id));
        }

        // POST: TiposAtividadeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,TipoAtividade tipoAtividade)
        {
            try
            {
                _repositorioTipoAtividade.ApagarAtividade(id);
                _contexto.Salvar();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
