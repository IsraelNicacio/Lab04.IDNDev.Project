using IDNDev.Core.DomainObject;

namespace IDNDev.Core.Data;

public interface IRepository<T> : IDisposable where T : EntityBase
{
}
