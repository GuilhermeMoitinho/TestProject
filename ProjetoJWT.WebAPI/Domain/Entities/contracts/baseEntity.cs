namespace ProjetoJWT.WebAPI.Domain.Entities
{
    public abstract class baseEntity
    {
        public Guid Id { get; private set; }

        public baseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
