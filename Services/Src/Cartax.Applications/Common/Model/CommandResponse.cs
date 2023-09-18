using Cartax.Applications.Common.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cartax.Applications.Common.Base
{
    public class CommandResponse : IResponse
    {




        public CommandResponse(bool isSuccess, string Message, int idtypeResult = 0)
        {
            IsSuccess = isSuccess;
            Errors.Add(Message);
            IdtypeResult = idtypeResult;
        }

        public bool IsSuccess { get; set; }
        public bool IsFailure { get; set; }
        public string Message { get; set; }
        public int IdtypeResult { get; set; }
        public object? Value { get; set; } = null;
        public List<string> Errors { get; set; } = new();

        public void ResponseFaild(string message, List<string> Errors)
        {
            IsSuccess = false;
            this.Errors = Errors;
            Message = message;
        }

        public void ResponseSuccess(string message, List<string> Errors)
        {
            IsSuccess = true;
            this.Errors = Errors;
            Message = message;
        }
    }
}
