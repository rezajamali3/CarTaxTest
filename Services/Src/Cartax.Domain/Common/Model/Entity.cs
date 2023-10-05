using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Common.Primitives;

namespace Cartax.Domain.Common.Model
{
    public class Entity : IEquatable<Entity>, IEntity<int?>
    {
 
        public int? Id { get; set; }

        public Entity(int? Id)
        {
            this.Id = Id;
        }

        public static bool operator ==(Entity? first, Entity? second)
        {
            return first is not null && second is not null && first.Equals(second);
        }

        public static bool operator !=(Entity? first, Entity? Secoend)
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

            if (!(obj is not Entity entity))
            {
                return false;
            }

            return Id == Id;
        }

        public bool Equals(Entity? other)
        {
            if (other == null)
                return false;


            if (other.GetType() != GetType())
            {
                return false;
            }

            return other.Id == Id;
        }

        public override int GetHashCode()
        {

            return Id.GetHashCode() * 48;
        }
    }
}
