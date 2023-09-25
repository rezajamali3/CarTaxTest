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

        public int? Idarea { get; private set; }
        public int? Idcar { get; private set; }

        private TaxCar(int? id) : base(id)
        {}

        private TaxCar(int? id, DateTime createDate, int area, int car, decimal? tax) : base(id)
        {
            CreateDate = createDate;
            Idcar = car;
            Idarea = area;
            Tax = tax;
        }


        public static TaxCar Create(int? id, DateTime createDate, string areaName, int idcar, int area,decimal? tax)
        {
            var taxCar = new TaxCar(id, createDate, area, idcar,tax);
            return taxCar;
        }



        public Area Area { get;  }

        public Car Car { get; }
     


    }
}
