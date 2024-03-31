using FIAP_PrimeiraApi.Api.Models;

namespace FIAP_PrimeiraApi.Api.Interfaces;

public interface IBancoDados
{
    int Inserir<T>();
    object Retornar(int id);
}
