using Cartax.Applications.Common.Primitives.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Common.Execeptions
{
    public class Error : IEquatable<Error>
    {
        public static readonly Error None = new(ErrorTypes.None, string.Empty);
        public static readonly Error NullValue = new(ErrorTypes.NullValue, string.Empty);
        public Error(ErrorTypes Code, string message)
        {
            this.Code = Code;
            Message = message;
        }


        public ErrorTypes Code { get; private set; }

        public string Message { get; private set; }


        public static implicit operator ErrorTypes(Error Error) => Error.Code;

        public static bool operator ==(Error? first, Error? secoend)
        {
            if (first is null && secoend is null)
            {
                return true;
            }

            if (first is null || secoend is null)
            {
                return true;
            }

            return first.Code == secoend.Code;
        }

        public static bool operator !=(Error? first, Error? secoend)
        {


            return !(first.Code == secoend.Code);
        }

        public bool Equals(Error? other)
        {
            throw new NotImplementedException();
        }



        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}