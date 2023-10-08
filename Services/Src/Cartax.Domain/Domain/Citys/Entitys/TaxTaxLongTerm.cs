

using Library_Domain.Model;


namespace Cartax.Domain.Domain.Citys.Entitys
{
    public class TaxTaxLongTerm : Entity<int?>
    {
     
        public bool? IsActive { get; private set; }

        public int? IdArea { get; private set; }
        public DateTime? DayStart { get; private set; }
        public DateTime? DayEnd { get; private set; }
    

        private TaxTaxLongTerm(int? id) : base(id)
        {
        }

        public static TaxTaxLongTerm Create(int? id ,int? idArea, DateTime? dayStart, DateTime? dayEnd)
        {
            return new TaxTaxLongTerm(id)
            {
                IdArea = idArea,
                DayStart = dayStart,
                DayEnd = dayEnd,
                IsActive = true
            };
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public Area Area { get;  }

    }
}
