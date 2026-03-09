using Facul.Application;
using Facul.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AlunoAPI.Controllers
{
    [ApiController]
    [Route("api/alunos")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService _service;

        public AlunoController(AlunoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Matricular(Aluno aluno)
        {
            _service.Matricular(aluno);
            return Ok("Aluno matriculado");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.Listar());
        }
    }
}