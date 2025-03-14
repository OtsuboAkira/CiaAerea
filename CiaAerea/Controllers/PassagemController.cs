using CiaAerea.Data;
using CiaAerea.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiaAerea.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassagemController : ControllerBase
    {
        readonly AppDbContext _context;

        public PassagemController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var passagens = _context.Passagens.ToList();
            if (passagens == null)
                return BadRequest("Não há passagens para essa rota!");

            return Ok(passagens);
        }

        [HttpGet("GetByReserva")]
        public IActionResult Get(int reserve)
        {
            var passagem = _context.Passagens.FirstOrDefault(x => x.Reserve == reserve);
            if (passagem == null)
                return BadRequest("Não existe passagem para essa reserva!");

            return Ok(passagem);
        }

        [HttpPost("PostPassagem")]
        public IActionResult Add([FromBody] Passagem passagem)
        {
            _context.Passagens.Add(passagem);
            if (passagem == null)
                return BadRequest("Falha ao adicionar passagem! Por gentileza revisar informações inseridas");

            _context.SaveChanges();

            return Ok(passagem);

        }

        [HttpPut("PutPassagem")]
        public IActionResult Put([FromBody] Passagem passagem)
        {
            var updatePassagem = _context.Passagens.FirstOrDefault(x => x.Reserve == passagem.Reserve);
            if (updatePassagem == null)
                return BadRequest("Passagem não encontrada!");

            updatePassagem.ValorPassagem = passagem.ValorPassagem;

            _context.Passagens.Update(updatePassagem);

            _context.SaveChanges();

            return Ok(updatePassagem);
        }

        [HttpDelete("DeletePassagem")]
        public IActionResult Delete(int reserve)
        {
            var deletePassagem = _context.Passagens.FirstOrDefault(x => x.Reserve == reserve);
            if (deletePassagem == null)
                return BadRequest("Passagem não encontrada!");

            _context.Passagens.Remove(deletePassagem);

            _context.SaveChanges();

            return Ok("Passagem deletada com sucesso!");
        }
    }
}
