
using Library_Domain.Interface;


namespace Library_Domain.Model
{
    public abstract class AggregateRoot : IAggregateRoot
    {

        public int Id { get; protected set; }


    }
}
