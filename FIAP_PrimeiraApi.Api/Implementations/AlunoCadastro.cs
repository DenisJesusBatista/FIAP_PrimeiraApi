using FIAP_PrimeiraApi.Api.Interfaces;
using FIAP_PrimeiraApi.Api.Models;

namespace FIAP_PrimeiraApi.Api.Implementations;

public class AlunoCadastro: IAlunoCadastro
{
    private readonly IBancoDados _bancoDados;

    public AlunoCadastro(IBancoDados bancoDados)
    {
        _bancoDados = bancoDados;        
    }

    public IList<Aluno> listaAluno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AtualizarAluno(Aluno dadosAluno)
    {
        throw new NotImplementedException();
    }

    public Aluno CriarAluno(Aluno dadosAluno)
    {
        throw new NotImplementedException();
    }

    public void DeletarAluno(int Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Aluno> ListarAlunos()
    {
        throw new NotImplementedException();
    }

    public Aluno RetornarAluno(int id)
    { 
        throw new NotImplementedException(); 
    }    
}
