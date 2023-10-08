
using Library_Domain.Interface;



namespace Library_Domain.Model
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>, IEntity<TId>
    {
<<<<<<< HEAD:Libraries/Library_Domain/Model/Entity.cs
        public TId Id { get;  }
       
=======
 
        public int? Id { get; set; }
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb:Services/Src/Cartax.Domain/Common/Model/Entity.cs

        public Entity(TId Id)
        {
            this.Id = Id;
        }

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

       
    }
}
