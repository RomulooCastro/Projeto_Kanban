using Projeto_Kanban.DTOs;
using Projeto_Kanban.Models;

namespace Projeto_Kanban.Services.Atividade
{
    public interface IAtividadeInterface 
    {
        Task<List<AtividadeModel>> BuscarAtividades();

        Task<List<StatusModel>> BuscarStatus();

        Task<AtividadeModel> CadastrarAtividade(CadastroAtividadeDTO cadastroAtividadeDTO);
    }
}
