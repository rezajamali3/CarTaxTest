using Cartax.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Domain.Entites.Tax.TaxPublicholidays
{
    public class TaxPublicholiday : Entity
    {

       
        [Column(TypeName = "Date")]
        public DateTime? Day { get; private set; }
        public bool? IsActive { get; private set; }

        private TaxPublicholiday(int? id) : base(id)
        {
        }

        private TaxPublicholiday(int? id, DateTime day) : base(id)
        {
            Id= id;
            Day = day;
            IsActive = true;
        }

        public static TaxPublicholiday Create(int? id,DateTime day)
        {
            return new TaxPublicholiday(id, day);
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
