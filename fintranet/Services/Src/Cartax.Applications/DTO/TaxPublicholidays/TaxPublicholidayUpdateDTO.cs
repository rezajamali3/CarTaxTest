﻿using Cartax.Applications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxPublicholidays
{
    public class TaxPublicholidayUpdateDTO : BaseDTO
    {
        public int? Id { get; set; }
        public DateTime Day { get; set; }
        public bool IsActive { get; set; }
    }
}
