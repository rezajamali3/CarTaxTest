using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Entites.Citys;
namespace Cartax.Domain.Entites.Areas
{

    public class Area : Entity
    {
        public string? AreaName { get; set; }
        public string? AreaCode { get; set; }

        public int? idCity;

        private Area(int? id):base(id)
        {
           
        }

        private Area(int id, string areaName, string areaCode, int? idcity) : base(id)
        {
            this.AreaName = areaName;
            this.AreaCode = areaCode;
            this.idCity = idCity;
        }


        public static Area Create(int id, string areaName, string areaCode, int? idcity)
        {
           
            return new Area(id, areaName, areaCode, idcity);
        }


        public static Area Create(int id)
        {
            return new Area(id, String.Empty, String.Empty,null);
        }

    }
}
