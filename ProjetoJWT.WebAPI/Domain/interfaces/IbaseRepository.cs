using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Domain.interfaces
{
    public interface IbaseRepository<T> where T : class
    {
        Task Add(T employe);
        Task<IEnumerable<T>> GetAll();
        Task Delete(T generic);
        void Update(T employe);
        Task<T> GetId(Guid id);

    }
}
