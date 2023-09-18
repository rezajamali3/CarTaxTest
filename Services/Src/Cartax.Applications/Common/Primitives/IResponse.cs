using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Common.Primitives
{
    public interface IResponse
    {
        public bool IsSuccess { get; set; }
        public bool IsFailure { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

    }
}
