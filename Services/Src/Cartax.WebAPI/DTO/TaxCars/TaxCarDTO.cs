using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.WebAPI.DTO.TaxCars
{
    public class TaxCarDTO : BaseDTO
    {
        public DateTime CreateDate { get; set; }
        public decimal Tax { get; set; }
        public int IdArea { get; set; }
        public int IdCar { get; set; }
    }
}
