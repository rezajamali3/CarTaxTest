using Libraries_Helper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Domain.ValueObjects
{
    public class Name
    {

        public string Value { get; }

        public Name(string name)
        {
            Value = name;
        }

        public static Name Create(string name)
        {
            if (name.Not_Empity())
                throw new ArgumentException($"{nameof(Name)} not Empity  ");

            int NameLenght = 60;

            if (name.Chack_Lenght(NameLenght))
                throw new ArgumentException($"{nameof(Name)} lass Lenght 60 Charchter  ");

            return new Name(name);
        }

    }
}
