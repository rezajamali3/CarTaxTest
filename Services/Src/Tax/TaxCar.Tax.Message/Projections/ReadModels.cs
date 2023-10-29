
namespace TaxCar.Tax.Message.Projections
{
    public  class ReadModels
    {
        public static class V1
        {

            public class DetailsTaxCarArea
            {

                public Guid  TaxCarAreaId { get; set; }
                public DateTime CreateDate { get; set; }
                public Decimal Tax { get; set; }
                public int Areaid { get; set; }
                public Guid CarId { get; set; }
                public int CombinedcameranumberId { get; set; }

            }

        

        }
    }
}
