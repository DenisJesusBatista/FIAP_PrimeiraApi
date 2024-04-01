using FIAP_PrimeiraApi.Api.Interfaces;
using FIAP_PrimeiraApi.Api.Logging;
using FIAP_PrimeiraApi.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIAP_PrimeiraApi.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AtendimentoController : ControllerBase
{
    //Forma 1 de Injeção
    private readonly IAlunoCadastro _alunoCadastro;

    private readonly ILogger<AtendimentoController> _logger;

    
    public AtendimentoController(IAlunoCadastro alunoCadastro, ILogger<AtendimentoController> logger)
    {
        _alunoCadastro = alunoCadastro;
        _logger = logger;
    }

    //FormatException 3 de injeção
    [HttpGet("aluno")]
    public IActionResult GetAluno(IServiceProvider serviceProvider, int id)
    {
        var alunoCadastro = serviceProvider.GetRequiredService<IAlunoCadastro>();

        CustomLogger.Arquivo = true;

        _logger.LogInformation("Teste de Log do tipo information");

        return Ok();
    }

    //Forma 2 de inseção
    //[HttpPost("inserirAluno")]
    //public IActionResult PostInserirAluno([FromKeyedServices("AlunoKeyed")] IAlunoCadastro alunoCadastro, [FromBody] Aluno aluno)
    //{
    //    alunoCadastro.CriarAluno(aluno);

    //    return Ok();
    //}

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
