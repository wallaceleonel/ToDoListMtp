using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TarefaController : Controller
    {
        private readonly Context _context;

        public TarefaController(Context context)
        {
            _context = context;
        }


        // GET: Todas as Tarefas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tarefas.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarTarefa()
        {
            return View();
        }
        // POST: Criar tarefa
        [HttpPost]
        public async Task<IActionResult> CriarTarefa(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(tarefa);
        }

        // HttpGet : Editar tarefa
        [HttpGet]
        public IActionResult EditarTarefa(int? id)
        {
            if (id != null)
            {
                var tarefa = _context.Tarefas.Find(id);
                return View(tarefa);
            }
            else return NotFound();
        }
        // HttpPost : Atualizar tarefa
        [HttpPost]
        public async Task<IActionResult> AtualizarTarefa(int? id, Tarefa tarefa)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(tarefa);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(tarefa);
            }
            else return NotFound();
        }

        // HttpGet excluir tarefa 

        [HttpGet]
        public IActionResult ExcluirTarefa(int? id)
        {
            if (id != null)
            {
                var tarefa = _context.Tarefas.Find(id);
                return View(tarefa);
            }
            else return NotFound();
        }

        // HttpPost Tarefa excluida

        [HttpPost]
        public async Task<IActionResult> ExcluirTarefa(int? id, Tarefa tarefa)
        {
            if (id != null)
            {
                _context.Remove(tarefa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

    }
}
