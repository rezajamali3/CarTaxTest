
using Cartax.Domain.Entites.Tax.TaxCars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Domain.Tax.Event;
using Library_Domain.Interface;

namespace Cartax.Domain.Domain.Tax.Event;

public  record NewTaxCarEnterEvent : IDomainEvent; 

