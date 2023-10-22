
using Library_Domain.Interface;



namespace Library_Domain.Model
{
    public abstract class Entity<TId> : IInternalEventHandler
      where TId : ValueObject<TId>
    {
        public Entity() { }

        //protected Entity(TId id) => Id = id;

        protected readonly Action<object> _applier;

        protected Entity(Action<object> applier) => _applier = applier;

        public TId Id { get; protected set; }

        void IInternalEventHandler.Handle(object @event) => When(@event);

        protected abstract void When(object @event);

        protected void Apply(object @event)
        {
            When(@event);
            _applier(@event);
            EnsureValidState();
        }
        protected abstract void EnsureValidState();

        #region Immutable

        public static bool operator ==(Entity<TId> first, Entity<TId> second)
        {
            return first is not null && second is not null && first.Equals(second);
        }

        public static bool operator !=(Entity<TId>?first, Entity<TId> Secoend)
        {
            return !(first == Secoend);
        }

        public override bool Equals(object? obj)
        {

            if (obj == null) return false;


            if (obj.GetType() != GetType())
            {
                return false;
            }

            if (!(obj is not Entity<TId> entity))
            {
                return false;
            }

            return (obj as Entity<TId>).Id.GetHashCode() == Id.GetHashCode();

        }

        public bool Equals(Entity<TId>? other)
        {
            if (other == null)
                return false;


            if (other.GetType() != GetType())
            {
                return false;
            }

            return other.Id.GetHashCode() == Id.GetHashCode();

        }

        public override int GetHashCode()
        {

            return Id.GetHashCode() * 48;
        }


        #endregion Immutable

    }
}