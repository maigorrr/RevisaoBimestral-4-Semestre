using Microsoft.AspNetCore.Mvc;
using RevisaoBimestral.Models;
using RevisaoBimestral.Repository;

namespace RevisaoBimestral.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EleitorController : ControllerBase
    {
        private readonly IEleitorRepository _eleitorRepository;

        public EleitorController(IEleitorRepository eleitorRepository)
        {
            _eleitorRepository = eleitorRepository;
        }


        [HttpPost]
        public IActionResult Cadastrar(Eleitor eleitor)
        {
            var resultado = _eleitorRepository.Cadastrar(eleitor);

            if (resultado != "Eleitor cadastrado com sucesso.")
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_eleitorRepository.ObterTodos());
        }


        [HttpPost("ausencia")]
        public IActionResult RegistrarAusencia(Ausencia ausencia)
        {
            var resultado =
                _eleitorRepository.RegistrarAusencia(ausencia);

            if (resultado != "Ausência registrada com sucesso.")
            {
                return BadRequest(resultado);
            }

            return Ok(resultado);
        }


        [HttpGet("ausencias")]
        public IActionResult ConsultarAusencias()
        {
            return Ok(_eleitorRepository.ObterAusencias());
        }
    }
}