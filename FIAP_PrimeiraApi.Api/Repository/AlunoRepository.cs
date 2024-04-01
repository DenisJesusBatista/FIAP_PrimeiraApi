using FIAP_PrimeiraApi.Api.Interfaces;
using FIAP_PrimeiraApi.Api.Models;

namespace FIAP_PrimeiraApi.Api.Repository;

public class AlunoRepository: IAlunoCadastro
{
    public IList<Aluno> listaAluno { get; set; }


    public AlunoRepository()
    {
        this.listaAluno = new List<Aluno>();
        
    }
    public void AtualizarAluno(Aluno dadosAluno)
    {
        throw new NotImplementedException();
    }

    public Aluno CriarAluno(Aluno dadosAluno)
    {
        dadosAluno.Id = listaAluno.Select(x => x.Id).Any() ? listaAluno.Select(x => x.Id).Max() + 1 : 1;
        listaAluno.Add(dadosAluno); 

        return dadosAluno;  
    }    

    public void DeletarAluno(int Id)
    {
        throw new NotImplementedException();   
    }

    public IEnumerable<Aluno> ListarAlunos()
    {
        return listaAluno;
    }

    public Aluno RetornarAluno(int id)
    {
        throw new NotImplementedException();
    }
}
