
using Microsoft.EntityFrameworkCore;
using Projeto_Kanban.Data;
using Projeto_Kanban.DTOs;
using Projeto_Kanban.Models;

namespace Projeto_Kanban.Services.Atividade
{
    public class AtividadeService : IAtividadeInterface
    {
        private readonly AppDbContext _context;

        public AtividadeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AtividadeModel>> BuscarAtividades()
        {
            try
            {
                var atividades = await  _context.Atividades.Include(x => x.Status).ToListAsync();

                return atividades;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StatusModel>> BuscarStatus()
        {
            try
            {
                var status = await _context.Status.ToListAsync();

                return status;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel>CadastrarAtividade(CadastroAtividadeDTO cadastroAtividadeDTO)
        {
            try
            {
                Random rand = new Random();

                var atividade = new AtividadeModel()
                {
                    Titulo = cadastroAtividadeDTO.Titulo,
                    Descricao = cadastroAtividadeDTO.Descricao,
                    StatusId = cadastroAtividadeDTO.StatusId,
                    Matricula = rand.Next(1000, 1000000)

                };

                _context.Atividades.Add(atividade);
                await _context.SaveChangesAsync();

                return atividade;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel> Deletar(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividades.FindAsync(atividadeId);

                _context.Remove(atividade);
                await _context.SaveChangesAsync();

                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel> MudarCard(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividades.FindAsync(atividadeId);

                atividade.StatusId++;

                _context.Update(atividade);
                await _context.SaveChangesAsync();

                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AtividadeModel> MudarCardAnterior(int atividadeId)
        {
            try
            {
                var atividade = await _context.Atividades.FindAsync(atividadeId);

                atividade.StatusId--;

                _context.Update(atividade);
                await _context.SaveChangesAsync();

                return atividade;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
