using Microsoft.AspNetCore.Mvc;
using Projeto_Kanban.Models;
using Projeto_Kanban.Services.Atividade;

namespace Projeto_Kanban.Controllers
{
    public class AtividadeController : Controller
    {
        private readonly IAtividadeInterface _atividadeInterface;

        public AtividadeController(IAtividadeInterface atividadeInterface)
        {
            _atividadeInterface = atividadeInterface;
            
        }

        public async Task<IActionResult> Index()
        {
            var atividades = await _atividadeInterface.BuscarAtividades();
            return View(atividades ?? new List<AtividadeModel>()); // Evita null
        }
    }
}
