using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Applications.Base;


namespace Cartax.Applications.Primitives
{

    public interface IDTO<T>
    {
        public T Id { get; set; }
    }


}
