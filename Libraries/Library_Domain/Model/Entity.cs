
using Library_Domain.Interface;



namespace Library_Domain.Model
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>> where TId : ValueObject<TId>
    {


        public TId Id { get;  }

        public Entity(TId Id)
        {
            this.Id = Id;
            _events = new List<object>();
        }


        #region Events

        protected Entity() => _events = new List<object>();

        private readonly List<object> _events;

        protected void Apply(object @event)
        {
            When(@event);
            EnsureValidState();
            _events.Add(@event);
        }

        protected abstract void When(object @event);

        public IEnumerable<object> GetChanges() => _events.AsEnumerable();

        public void ClearChanges() => _events.Clear();

        protected abstract void EnsureValidState();

        #endregion Events

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