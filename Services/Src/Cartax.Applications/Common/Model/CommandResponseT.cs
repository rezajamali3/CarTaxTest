using Cartax.Applications.Common.Execeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Common.Base
{
    public class CommandResponse<TValue> : CommandResponse
    {

        private readonly TValue? _value;

        public CommandResponse(bool IsSuccess, Error error) : base(IsSuccess, error.Message)
        {

        }

        public CommandResponse(TValue? value, bool IsSuccess, Error error)
            : base(IsSuccess, error.Message)
            => _value = value;



        public TValue value => IsFailure ? _value!
            : throw new InvalidOperationException("The value of a Failure can not be accessed");

        public static CommandResponse<TValue> Failure(Error? error)
        => new CommandResponse<TValue>(false, error);




        public static CommandResponse<TValue> Failure<TValue>(TValue? value, Error? error)
        => new CommandResponse<TValue>(value, false, error);



        public static implicit operator CommandResponse<TValue>(TValue? value) => value;


    }
}
