using CiaAerea.Data;
using CiaAerea.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiaAerea.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VooController : ControllerBase
    {
        readonly AppDbContext _context;
        public VooController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var voos = _context.Voos.ToList();
            if (voos == null)
                BadRequest("Não há voos para essa rota");

            return Ok(voos);
        }

        [HttpGet("GetByNumeroVoo")]
        public IActionResult Get(int numeroVoo)
        {
            var voo = _context.Voos.FirstOrDefault(x => x.NumeroVoo == numeroVoo);
            if (voo == null)
                BadRequest("Não há voo para esse número");

            return Ok(voo);
        }

        [HttpPost("PostVoo")]
        public IActionResult Post([FromBody] Voo voo)
        {
            _context.Voos.Add(voo);
            if (voo == null)
                BadRequest("Falha ao adicionar voo! Por gentileza revisar informações inseridas");

            _context.SaveChanges();

            return Ok(voo);
        }

        [HttpPut("PutVoo")]
        public IActionResult Put([FromBody] Voo voo)
        {
            var updateVoo = _context.Voos.FirstOrDefault(x => x.NumeroVoo == voo.NumeroVoo);
            if (updateVoo == null)
                BadRequest("Voo não encontrado!");

            updateVoo.Origem = voo.Origem;
            updateVoo.Destino = voo.Destino;
            updateVoo.HorarioPartida = voo.HorarioPartida;
            updateVoo.NumeroTotalAssentos = voo.NumeroTotalAssentos;

            _context.Voos.Update(updateVoo);

            _context.SaveChanges();

            return Ok(updateVoo);
        }

        [HttpDelete("DeleteVoo")]
        public IActionResult Delete(int numeroVoo)
        {
            var deleteVoo = _context.Voos.FirstOrDefault(x => x.NumeroVoo == numeroVoo);
            if (deleteVoo == null)
                BadRequest("Voo não encontrado!");

            _context.Voos.Remove(deleteVoo);

            _context.SaveChanges();

            return Ok("Voo removido com sucesso!");
        }
    }
}
