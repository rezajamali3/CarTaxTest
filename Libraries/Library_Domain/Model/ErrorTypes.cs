using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.Model
{
    public enum ErrorTypes
    {
        None = 0,
        NullValue = 1,
        Create = 2,
        Delete = 3,
        Update = 4,
        Domain = 5
    }
}
