
using Libraries_Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Area.Domain.ValueObjects
{
    public class AreaCode
    {

        public string Value { get; }

        protected AreaCode() { }

        private AreaCode(string cityCode)
        {
            Value = cityCode;
        }

        public static AreaCode Create(string cityCode)
        {
            if(cityCode.Not_Empity())
                throw new ArgumentNullException(nameof(cityCode) +"not null");

            if (cityCode.Chack_Lenght(3))
                throw new Exception(nameof(cityCode) + "lass 3 Charter");

            return new AreaCode(cityCode);
        }

        public static implicit operator string(AreaCode name) => name.Value;



    }
}
