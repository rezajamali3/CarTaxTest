<<<<<<< HEAD:Services/Src/CarTax.Car/CarTax.Car.Domain/ValueObjects/CarTypeincludingtax.cs
﻿using CarTax.Car.Domain.Entitys;
using Library_Domain.Model;
=======
﻿

using Cartax.Domain.Common.Model;
using Cartax.Domain.Entites.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb:Services/Src/Cartax.Domain/Domain/Cars/ValueObjects/CarTypeincludingtax.cs

namespace CarTax.Car.Domain.ValueObjects
{
    public class CarTypeincludingtax : ValueObject
    {
        public CarType CarTypes { get; private set; }

        public CarTypeincludingtax(CarType carTypes)
        {
            CarTypes = carTypes;
        }

        public static CarTypeincludingtax Create(CarType carTypes)
        {
            return new CarTypeincludingtax(carTypes);
        }


        public bool? Carincludingtax()
        {
            return CarTypes.IsTaxActive;
        }



        public override IEnumerable<object> GetAtomicValues()
        {
            yield return CarTypes;
        }


    }
}
