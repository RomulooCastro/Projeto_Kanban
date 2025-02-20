using System.ComponentModel.DataAnnotations;

namespace Projeto_Kanban.DTOs
{
    public class CadastroAtividadeDTO
    {
        [Required(ErrorMessage = "Digite o Titulo")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Digite a Descrição")]
        public string? Descricao { get; set; }

        public DateTime DataDescricao { get; set; } = DateTime.Now; //assim que iniciar, a data criacao ja vai ser a atual

        [Required(ErrorMessage = "Selecione um Status")]
        public int StatusId { get; set; }
    }
}
