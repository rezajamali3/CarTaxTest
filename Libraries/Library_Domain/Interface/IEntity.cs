

namespace Library_Domain.Interface
{
    public interface IEntity<TId>
    {
        public TId Id { get;  }
    }
}
