namespace Projeto_Kanban.DTOs
{
    public class CadastroAtividadeDTO
    {

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public DateTime DataDescricao { get; set; } = DateTime.Now; //assim que iniciar, a data criacao ja vai ser a atual

        public int StatusId { get; set; }
    }
}
