using Cartax.Domain.Common.Errors;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Common.Model
{
    public class DomainResult
    {

        public DomainResult(bool IsSuccess, Error error)
        {
            SetData(IsSuccess, error);
        }

        public void SetData(bool IsSuccess, Error error)
        {
            if (error is null)
            {
                throw new InvalidOperationException();
            }



            this.IsSuccess = IsSuccess;
            this.error = error;


        }

        public bool IsSuccess { get; set; }

        public bool IsFailure => !IsSuccess;

        public Error error { get; private set; }

        public object Data { get; set; }

    }
}
