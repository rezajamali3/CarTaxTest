using Cartax.Domain.Entites.Areas;
using Cartax.Domain.Entites.Citys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;
using Cartax.Domain.Base;

namespace Cartax.Presentation.Base
{
    public class BaseDataConfiguertions<T> : IEntityTypeConfiguration<T> where T : Entity
    {

        protected  IEnumerable<T> Data;

        public void Configure(EntityTypeBuilder<T> builder)
        {

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<T> builder)
        {


            IEnumerable<T> values = DataDefultConfig<T>();

            if (DataExists(builder)==false)
            {

                builder.HasData(values);

            }
        }
        
        private  IEnumerable<T> DataDefultConfig<T>()
        {
            return (IEnumerable<T>)Data;
        }

        private bool DataExists(EntityTypeBuilder<T> builder)
        {
            // بررسی وجود داده در جدول
            return builder.Metadata.GetSeedData().Any();
        }

       

    }
}
