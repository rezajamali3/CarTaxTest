using Libraries_Helper;
using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTax.Car.Domain.ValueObjects
{
    public class Plack : ValueObject<Plack>
    {
        
        public string Value  => $"{CodePlack}:{NumberPlack}";

        public Plack()
        {
            
        }


        public Plack( string codePlack,string numberPlack) { 
        
            CodePlack = codePlack;
            NumberPlack = numberPlack;
        
        }

        
        public static Plack  Create(string codePlack, string codeNumber)
        {
            int lenghtCodePlack = 2;

            if (codePlack.Not_Empity())
                throw new ArgumentException("Null");

            if (codePlack.Chack_Lenght(lenghtCodePlack))
                throw new ArgumentException("Null");

            int lenghtNumberPlack = 20;

            if (codeNumber.Not_Empity())
                throw new ArgumentException("Null");

            if (codeNumber.Chack_Lenght(lenghtNumberPlack))
                throw new ArgumentException("Lenth");

            return new Plack(codePlack, codeNumber);

        }

        public string CodePlack { get;  }

        public string NumberPlack { get; }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return CodePlack;
            yield return NumberPlack;
        }

        public override string ToString()
        {
            return   $"{CodePlack.ToString()} {Value}";
        }
    }
}
