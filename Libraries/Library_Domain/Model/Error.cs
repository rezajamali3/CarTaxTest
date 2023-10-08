
using Library_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Model
{
    public class Error : IError
    {
        public static readonly Error None = new(ErrorTypes.None, "بدون خطا ...", (int)ErrorTypes.None);
        public static readonly Error NullValue = new(ErrorTypes.NullValue, "مقدار نا معتبر", (int)ErrorTypes.NullValue);
        public Error(ErrorTypes Code, string message, int idCode = 0)
        {
            this.Code = Code;
            Message = message;
            this.idCode = idCode;
        }


        public ErrorTypes Code { get; private set; }
        public int idCode { get; private set; }

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
