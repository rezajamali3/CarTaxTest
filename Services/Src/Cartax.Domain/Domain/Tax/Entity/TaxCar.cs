using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cartax.Domain.Entites.Cars;

using System.ComponentModel.DataAnnotations.Schema;
using Cartax.Domain.Common.Model;
using Cartax.Domain.Domain.Citys.Entitys;

namespace Cartax.Domain.Entites.Tax.TaxCars
{
    public class TaxCar : Entity
    {
        public DateTime? CreateDate { get; private set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tax { get; private set; }

        public Area Area { get; private set; }
        public Car Car { get; private set; }

        private TaxCar(int? id) : base(id)
        {}

        private TaxCar(int? id, DateTime createDate, Area area, Car car, decimal? tax) : base(id)
        {
            CreateDate = createDate;
            this.Car = car;
            this.Area = area;
            Tax = tax;
        }


        public static TaxCar Create(int? id, DateTime createDate, string areaName, Car car, Area area, decimal? tax)
        {
            var taxCar = new TaxCar(id, createDate, area, car, tax);
            return taxCar;
        }


    }
}
