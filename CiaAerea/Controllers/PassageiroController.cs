using CiaAerea.Data;
using CiaAerea.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiaAerea.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassageiroController : ControllerBase
    {
        readonly AppDbContext _context;

        public PassageiroController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var passageiros = _context.Passageiros.ToList();

            return Ok(passageiros);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var passageiro = _context.Passageiros.FirstOrDefault(x => x.Id == id);
            if (passageiro == null)
                return BadRequest("Passageiro não encontrado!");

            return Ok(passageiro);
        }

        [HttpPost("PostPassageiro")]
        public IActionResult Post([FromBody] Passageiro passageiro)
        {
            _context.Passageiros.Add(passageiro);
            if (passageiro == null)
                return BadRequest("Falha ao adicionar passageiro! Por gentileza revisar informações inseridas");

            _context.SaveChanges();
            
            return Ok(passageiro);
        }

        [HttpPut("PutPassageiro")]
        public IActionResult Put([FromBody] Passageiro passageiro)
        {
            var updatePassageiro = _context.Passageiros.FirstOrDefault(x => x.Id == passageiro.Id);
            if (updatePassageiro == null)
                return BadRequest("Passageiro não encontrado!");

            updatePassageiro.PrimeiroNome = passageiro.PrimeiroNome;
            updatePassageiro.UltimoSobrenome = passageiro.UltimoSobrenome;
            updatePassageiro.Documento = passageiro.Documento;

            _context.Passageiros.Update(updatePassageiro);

            _context.SaveChanges();

            return Ok(updatePassageiro);
        }

        [HttpDelete("DeletePassageiro")]
        public IActionResult Delete(int id)
        {
            var deletePassageiro = _context.Passageiros.FirstOrDefault(x => x.Id == id);
            if (deletePassageiro == null)
                return BadRequest("Passageiro não encontrado!");

            _context.Passageiros.Remove(deletePassageiro);

            _context.SaveChanges();

            return Ok("Passageiro deletado com sucesso!");
        }
    }
}
