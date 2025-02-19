namespace Projeto_Kanban.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }

        public int Matricula { get; set; }

        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public DateTime DataDescricao { get; set; } = DateTime.Now; //assim que iniciar, a data criacao ja vai ser a atual

        public int StatusId { get; set; }

        public StatusModel Status { get; set; }

    }
}
