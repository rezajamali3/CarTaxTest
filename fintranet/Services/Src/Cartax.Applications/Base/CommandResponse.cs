
using Cartax.Applications.Execeptions;
using Cartax.Applications.Sharid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cartax.Applications.Base
{
    public class CommandResponse : IResponse
    {
       

       

        public CommandResponse(bool isSuccess , string Message, int idtypeResult = 0 )
        {
            this.IsSuccess = isSuccess;
            Errors.Add( Message);
            IdtypeResult = idtypeResult;
        }

        public bool IsSuccess { get; set; }
        public bool IsFailure { get; set ; }
        public string Message { get ; set ; }
        public int IdtypeResult { get; set; }
        public object? Value { get; set; } = null;
        public List<string> Errors { get; set; } = new();

        public void ResponseFaild(string message, List<string> Errors)
        {
            this.IsSuccess = false;
            this.Errors = Errors;
            this.Message = message;
        }

        public void ResponseSuccess(string message, List<string> Errors)
        {
            this.IsSuccess = true;
            this.Errors = Errors;
            this.Message = message;
        }
    }
}
