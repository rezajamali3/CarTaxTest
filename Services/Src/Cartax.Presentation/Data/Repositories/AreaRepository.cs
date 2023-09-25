﻿using Cartax.Applications.Common.Base;
using Cartax.Applications.Persistence.Repositories;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Presentation.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Presentation.Data.Repositories
{
    public class AreaRepository : RepositoryBase<Area>, IAreaRipository
    {
        public AreaRepository(CarTaxContext dbContext) : base(dbContext)
        {

        }
    }
}
