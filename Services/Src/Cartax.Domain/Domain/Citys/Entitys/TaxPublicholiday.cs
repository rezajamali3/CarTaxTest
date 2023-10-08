

using Library_Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxPublicholiday : Entity<int?>
    {
        public DateTime? Day { get; private set; }
        public bool? IsActive { get; private set; }
        
        public City City { get; private set; }

        private TaxPublicholiday(int id) : base(id)
        {
        }

<<<<<<< HEAD
        private TaxPublicholiday(int id, DateTime day, int? idArea) : base(id)
=======
        private TaxPublicholiday(int? id, DateTime day, City city) : base(id)
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
        {
          
            Day = day;
            IsActive = true;
            City = city;
        }

<<<<<<< HEAD
        public static TaxPublicholiday Create(int id,DateTime day, int? idArea)
=======
        public static TaxPublicholiday Create(int? id,DateTime day, City city)
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb
        {
            return new TaxPublicholiday(id, day, city);
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

    

    }
}
