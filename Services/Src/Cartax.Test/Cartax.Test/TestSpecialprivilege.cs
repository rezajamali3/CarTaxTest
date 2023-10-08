using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Domain.Entites.Tax.TaxCars;


namespace Cartax.Test
{
    public class TestSpecialprivilege
    {

        private DateTime dateCreate = new DateTime(2013, 2, 4, 8, 8, 8);

        private const int idPublicEntry = 1;
        private const int idPublicEntry_2 = 1;

        private const int idCity    = 1;
        private const int idCar     = 1;
        private const int idCarTyps = 1;
        private const int idArea    = 1;

        private const int Tax1 = 10;
        private const int Tax2 = 20;
        private const int Tax3 = 30;

        private const bool isTax_Yes = true;
        private const bool isTax_No  = false;

        private const bool isActive_Yes = true;
        private const bool isActive_No  = false;


        private const int NoError = 0;

        int[] WeekDay = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        [Fact]
        public async Task text_Domain_Specialprivilege()
        {
            // Arrange

            //var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            //decimal taxCarTody = 0;
            //int taxidenterAndExit = 0;
            //bool Holaday = false;
            //bool HoladayNext = false;
            //bool taxtaxLongTime = false;
            //TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
           
            //var taxCarResult = TaxCarArea.Create(
            //    cartype,
            //    null,
            //    taxCarTody,
            //    null,
            //    taxidenterAndExit,
            //    Holaday,
            //    HoladayNext,
            //    taxtaxLongTime,
            //    taxTime,
            //    dateCreate
            //    );


            //// Act
            //var result = taxCarResult.TaxCarAreaContract();

            //// Assert
            //Assert.NotNull(result);
            //Assert.True(result.IsSuccess);
        }
                                                                                            
       

    }
}
