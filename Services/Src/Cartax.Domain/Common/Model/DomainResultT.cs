using Cartax.Domain.Common.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Common.Model
{
    public class DomainResult<TValue> : DomainResult
    {

        private readonly TValue? _value;

        public DomainResult(bool IsSuccess, Error error) : base(IsSuccess, error)
        {
        }

        public DomainResult(TValue? value, bool IsSuccess, Error error)
            : base(IsSuccess, error)
            => _value = value;



        public TValue value => IsFailure ? _value!
            : throw new InvalidOperationException("The value of a Failure can not be accessed");

        public static DomainResult<TValue> Failure(Error? error)
        => new DomainResult<TValue>(false, error);




        public static DomainResult<TValue> Failure<TValue>(TValue? value, Error? error)
        => new DomainResult<TValue>(value, false, error);



        public static implicit operator DomainResult<TValue>(TValue? value) => value;


    }
}
