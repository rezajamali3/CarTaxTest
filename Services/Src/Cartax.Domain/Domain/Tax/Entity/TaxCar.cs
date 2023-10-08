using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.ComponentModel.DataAnnotations.Schema;

using Cartax.Domain.Domain.Citys.Entitys;
using Library_Domain.Model;

namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCar : Entity<int>
    {
        public DateTime? CreateDate { get; private set; }

      
        public decimal? Tax { get; private set; }

        public Area Area { get; private set; }
        public Car Car { get; private set; }

        private TaxCar(int id) : base(id)
        {}

<<<<<<< HEAD
        private TaxCar(int id, DateTime createDate, int area, int car, decimal? tax) : base(id)
=======
        private TaxCar(int? id, DateTime createDate, Area area, Car car, decimal? tax) : base(id)
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
        {
            CreateDate = createDate;
            this.Car = car;
            this.Area = area;
            Tax = tax;
        }


<<<<<<< HEAD
        public static TaxCar Create(int id, DateTime createDate, string areaName, int idcar, int area,decimal? tax)
=======
        public static TaxCar Create(int? id, DateTime createDate, string areaName, Car car, Area area, decimal? tax)
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
        {
            var taxCar = new TaxCar(id, createDate, area, car, tax);
            return taxCar;
        }


<<<<<<< HEAD

        public Area Area { get;  }

    
     


=======
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
    }
}
