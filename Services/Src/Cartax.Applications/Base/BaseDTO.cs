using Cartax.Applications.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Base
{
    public class BaseDTO : IDTO<int>
    {
        public int Id { get ; set ; }
    }
}
