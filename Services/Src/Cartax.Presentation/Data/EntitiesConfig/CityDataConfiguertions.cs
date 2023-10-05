using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Presentation.Base;

namespace Cartax.Presentation.Data.EntitiesConfig
{
    public class CityDataConfiguertions : BaseDataConfiguertions<City>
    {

        public CityDataConfiguertions()
        {

            setData();
        }

        private void setData()
        {
            Data  = new City[]
            {
                 //City.Create(1,"Theran","bpe"),
                 // City.Create(2,"Busher","bpe"),
                 //  City.Create(3,"Avesta","bpe"),
            };

          
        }


    }
}
