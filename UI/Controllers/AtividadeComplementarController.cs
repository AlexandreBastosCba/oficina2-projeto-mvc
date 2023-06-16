using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contratos;
using Repositorio;
using Entidade;

namespace UI.Controllers
{
    public class AtividadeComplementarController : Controller
    {

        private readonly IContexto _contexto;
        private readonly IRepositorioAtividadeComplementar _repositorioAtividadeComplementar;
        private RepositorioAluno _repositorioAluno;
        private RepositorioTipoAtividade _repositorioTipoAtividade;

        public AtividadeComplementarController(DbContextOptions dbcontext)
        {

            _contexto = new Contexto(dbcontext);
            _repositorioAtividadeComplementar = new RepositorioAtividadeComplementar(_contexto);
            _repositorioAluno = new RepositorioAluno(_contexto);
            _repositorioTipoAtividade = new RepositorioTipoAtividade(_contexto);
        }
        // GET: AtividadeComplementarController
        public ActionResult Index()
        {
            return View(_repositorioAtividadeComplementar.BuscarAtividadesComplementar());
        }

        // GET: AtividadeComplementarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtividadeComplementarController/Create
        public ActionResult Create()
        {
            var atividadecomplementar = new AtividadeComplementar();
            atividadecomplementar.AlunosParaSelecao = _repositorioAluno.BuscarAluno();
            atividadecomplementar.TipoAtividadesParaSelecao = _repositorioTipoAtividade.BuscarAtividades();

            return View(atividadecomplementar);
        }

        // POST: AtividadeComplementarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AtividadeComplementar atividadeComplementar)
        {
            try
            {
                _repositorioAtividadeComplementar.AddAtividadeComplementar(atividadeComplementar);
                _contexto.Salvar();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtividadeComplementarController/Edit/5
        public ActionResult Edit(int id)
        {
            var atividadecomplementar = _repositorioAtividadeComplementar.BuscarAtividadComplementarPorCodigo(id);
            atividadecomplementar.AlunosParaSelecao = _repositorioAluno.BuscarAluno();
            atividadecomplementar.TipoAtividadesParaSelecao = _repositorioTipoAtividade.BuscarAtividades();
            return View(atividadecomplementar);
        }

        // POST: AtividadeComplementarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AtividadeComplementar atividadeComplementar)
        {
            try
            {
                _repositorioAtividadeComplementar.AtualizarAtividadeComplementar(atividadeComplementar.AtividadeComplementarId, atividadeComplementar);
                _contexto.Salvar();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtividadeComplementarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repositorioAtividadeComplementar.BuscarAtividadComplementarPorCodigo(id));
        }

        // POST: AtividadeComplementarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AtividadeComplementar atividadeComplementar)
        {
            try
            {
                _repositorioAtividadeComplementar.ApagarAtividadeComplementar(id);
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
