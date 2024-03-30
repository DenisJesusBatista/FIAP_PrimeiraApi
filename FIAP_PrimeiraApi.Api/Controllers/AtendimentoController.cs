using FIAP_PrimeiraApi.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FIAP_PrimeiraApi.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AtendimentoController : ControllerBase
{
    private readonly IAlunoCadastro _alunoCadastro;

    public AtendimentoController(IAlunoCadastro alunoCadastro)
    {
        _alunoCadastro = alunoCadastro;
    }

    [HttpGet("aluno")]
    public IActionResult GetAluno()
    {
        return Ok(_alunoCadastro.ListarAlunos());
    }

    [HttpPost("inserirAluno")]
    public IActionResult CriarAluno()
    {
        return Ok();
    }

    [HttpPut("atualizacaoAluno")]
    public IActionResult PutAtualizacaoAluno()
    {
        return Ok();
    }

    [HttpDelete("deleteAluno")]
    public IActionResult DeleteAluno()
    {
        return Ok();
    }
}
