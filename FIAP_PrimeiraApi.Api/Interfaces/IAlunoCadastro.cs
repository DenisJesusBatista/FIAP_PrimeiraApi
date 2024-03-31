using FIAP_PrimeiraApi.Api.Models;

namespace FIAP_PrimeiraApi.Api.Interfaces;

public interface IAlunoCadastro
{
    IList<Aluno> listaAluno { get; set; }

    //Contratos que serão utilizados na nossa implementação
    public Aluno RetornarAluno(int id);
    public IEnumerable<Aluno> ListarAlunos();
    public Aluno CriarAluno(Aluno dadosAluno);
    public void AtualizarAluno(Aluno dadosAluno);
    public void DeletarAluno(int Id);
}
