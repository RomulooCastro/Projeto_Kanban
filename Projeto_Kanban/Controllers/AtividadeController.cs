using Microsoft.AspNetCore.Mvc;
using Projeto_Kanban.DTOs;
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

        public async Task<IActionResult> Cadastrar()
        {
            var status = await _atividadeInterface.BuscarStatus();

            // Criação do modelo para a view com status carregado
            var model = new CadastroAtividadeDTO();

            // Atribuindo a lista de Status ao ViewBag
            ViewBag.Status = status;

            return View(model);  // Passando o modelo vazio para a view
        }

        public async Task<IActionResult> MudarCard(int id)
        {
            var atividade = await _atividadeInterface.MudarCard(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MudarCardAnterior(int id)
        {
            var atividade = await _atividadeInterface.MudarCardAnterior(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var atividade = await _atividadeInterface.Deletar(id);

            return RedirectToAction("Index");
        }



        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastroAtividadeDTO cadastroAtividadeDTO)
        {
            if (ModelState.IsValid)
            {
                var atividade = await _atividadeInterface.CadastrarAtividade(cadastroAtividadeDTO);
                return RedirectToAction("Index");
            }
            else
            {
                // Se a validação falhar, carregar a lista de status novamente e retornar o modelo com os dados já preenchidos
                var status = await _atividadeInterface.BuscarStatus();
                ViewBag.Status = status;

                return View(cadastroAtividadeDTO); // Passando o modelo com erros de validação para a view
            }
        }

    }
}
