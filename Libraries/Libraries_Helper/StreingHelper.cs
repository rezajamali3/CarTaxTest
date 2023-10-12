using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_Helper
{
    public static class StringHelper
    {
         public static bool Not_Empity(this string Value)
        =>   string.IsNullOrWhiteSpace(Value);
        

        public static bool Chack_Lenght(this string Value,int Length)
        =>   Value.Length > Length;

    }
}
