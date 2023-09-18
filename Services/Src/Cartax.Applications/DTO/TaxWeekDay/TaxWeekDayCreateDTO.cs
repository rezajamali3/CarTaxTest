﻿using Cartax.Applications.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.TaxWeekDay
{
    public class TaxWeekDayCreateDTO : BaseDTO
    {
        public int IdArea { get; set; }
        public int DatyTyps { get; set; }
        public int TaxDays { get; set; }
        public bool IsActive { get; set; }
    }
}
