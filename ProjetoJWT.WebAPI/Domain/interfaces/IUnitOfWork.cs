namespace ProjetoJWT.WebAPI.Domain.interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
