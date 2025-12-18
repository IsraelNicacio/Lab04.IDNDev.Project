using IDNDev.Core.Data;

namespace IDNDev.Cadastros.Api.Domain;

public interface IPessoaRepository : IRepository<Pessoa>
{
    Task<IEnumerable<Pessoa>> Listar();
    Task<Pessoa> RecuperarPorId(Guid id);
    Task Adicionar(Pessoa pessoa);
}