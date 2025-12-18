using IDNDev.Cadastros.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace IDNDev.Cadastros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository) => _pessoaRepository = pessoaRepository;

        [HttpGet(Name = "listar")]
        public async Task<IActionResult> Get()
        {
            var result = await _pessoaRepository.Listar();

            return Ok(result);
        }
    }
}
