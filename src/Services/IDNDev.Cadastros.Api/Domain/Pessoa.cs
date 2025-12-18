using IDNDev.Core.DomainObject;

namespace IDNDev.Cadastros.Api.Domain;

public class Pessoa : EntityBase
{
    public string Nome { get; set; }
    public string Documento { get; set; }
    public int Idade { get; set; }
}
