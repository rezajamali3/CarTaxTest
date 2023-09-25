using Cartax.Applications.Base;
using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Primitives;

public interface IQuery<TResponse> : IRequest<CommandResponse<TResponse>>
{
}

