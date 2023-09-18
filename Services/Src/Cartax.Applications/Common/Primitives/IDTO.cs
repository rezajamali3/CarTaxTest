using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cartax.Applications.Common.Primitives
{

    public interface IDTO<T>
    {
        public T Id { get; set; }
    }


}
