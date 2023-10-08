using Library_Domain.Interface;

namespace Library_Domain.Model
{
    public abstract class DomainEvent : IEquatable<DomainEvent>, IDomainEvent 
    {

        public DomainEvent()
        {
            _events = new();
        }

        public Guid Id { get; protected set; }

        public int Version { get; protected set; }

        public  List<IDomainEvent> _events { get ;private set ; } 
       
        public void AddEvent(IDomainEvent @event) => _events.Add(@event);
        

        public void ClearEvents() => _events.Clear();

        public bool Equals(DomainEvent? other)
        {
           return true;
        }

        public IEnumerable<IDomainEvent> GetEvents()=>_events.ToList();

        public Task StartEvent(IDomainEvent data)
        {
            throw new NotImplementedException();
        }



       

        //public bool Equals(NewTaxCarEnterEvent other)
        //{
        //    if (other == null)
        //        return false;

        //    // بررسی ویژگی‌های مورد نظر برای برابری رویدادها
        //    return true;
        //}

        public override int GetHashCode()
        {
            // پیاده‌سازی کد هش برای رویداد
            // می‌توانید از مقادیر مورد نظر برای محاسبه کد هش استفاده کنید
            return 48;
        }

    
    }
}
