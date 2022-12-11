namespace DevTubeCommerce.Infrastructure.Patterns;

public interface IUnitOfWork : IDisposable
{
    Task SaveChanges();
}
