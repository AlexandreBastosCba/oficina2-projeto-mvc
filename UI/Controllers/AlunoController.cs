using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contratos;
using Repositorio;
using Entidade;

namespace UI.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        private readonly IContexto _contexto;
        private readonly IRepositorioAluno _repositorioAluno;

        public AlunoController(DbContextOptions dbcontext)
        {

            _contexto = new Contexto(dbcontext);
            _repositorioAluno = new RepositorioAluno(_contexto);

        }
        // GET: Aluno/Details/5
        public ActionResult Index()
        {
            return View(_repositorioAluno.BuscarAluno());
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                _repositorioAluno.AddAluno(aluno);
                _contexto.Salvar();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repositorioAluno.BuscarAlunoPorCodigo(id));
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aluno aluno)
        {
            try
            {
                _repositorioAluno.AtualizarAluno(aluno.AlunoId, aluno);
                _contexto.Salvar();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repositorioAluno.BuscarAlunoPorCodigo(id));
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Aluno aluno)
        {
            try
            {
                _repositorioAluno.ApagarAluno(id);
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
