namespace TaxCar.Combinedstation.Core
{

    public class CombinedStations
    {

        public Guid   CombinedStationsId { get; set; }

        public int    AreaId { get; set; }

        public string StationName { get; set; }

        public string StationCode { get; set; }

        public bool   IsActive { get; set; }

    }

}