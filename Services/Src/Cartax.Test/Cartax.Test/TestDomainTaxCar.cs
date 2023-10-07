
using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Tax.TaxCars;
using Cartax.Domain.Entites.Tax.TaxTimes;
using Cartax.Domain.Entites.Tax.TaxWeekDays;
using Cartax.Domain.Sharid.Enume;






namespace CarTax.Test1
{
    public class TestDomainTaxCar
    {

        private DateTime dateCreate = new DateTime(2013, 2, 4,8, 8, 8);

        private const int idPublicEntry = 1;
        private const int idPublicEntry_2 = 1;

        private const int idCity = 1;
        private const int idCar = 1;
        private const int idCarTyps = 1;
        private const int idArea = 1;

        private const int Tax1 = 10;
        private const int Tax2 = 20;
        private const int Tax3 = 30;

        private const bool isTax_Yes = true;
        private const bool isTax_No = false;

        private const bool isActive_Yes = true;
        private const bool isActive_No = false;


        private const int NoError = 0;

        int[] WeekDay = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        [Fact]
        public async Task text_Domain_TaxCar_NewInsertTaxCar()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
              List<TaxCar> listTaxCar = new() 
              {
              TaxCar.Create(idPublicEntry,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
            List<TaxWeekDay> taxWeekDays = new()
            {
                TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };
            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;
            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            var taxCarResult = TaxCarArea.Create(cartype, listTaxCar, taxCarTody, taxWeekDays, taxidenterAndExit, Holaday, HoladayNext, taxtaxLongTime, taxTime, dateCreate);
          
            
            // Act
             var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async Task text_Domain_TaxCar_TypeCar_CarTaxNone()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_No);
            List<TaxCar> listTaxCar = new()
              {
              TaxCar.Create(idPublicEntry,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };
            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;
            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            var taxCarResult = TaxCarArea.Create(null, listTaxCar, taxCarTody, taxWeekDays, taxidenterAndExit, Holaday, HoladayNext, taxtaxLongTime, taxTime, dateCreate);


            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode,(int)ErrorDomainTypes.CarTypesNull);
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public async Task text_Domain_TaxCar_TypeCar_CarTypesNoTax()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_No);
            List<TaxCar> listTaxCar = new()
              {
              TaxCar.Create(idPublicEntry,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };
            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;
            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            var taxCarResult = TaxCarArea.Create(cartype, listTaxCar, taxCarTody, taxWeekDays, taxidenterAndExit, Holaday, HoladayNext, taxtaxLongTime, taxTime, dateCreate);


            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.CarTypesNoTax);
            Assert.False(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_TypeCar_CarTypesYesTax()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
              {
              TaxCar.Create(idPublicEntry,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };
            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;
            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            var taxCarResult = TaxCarArea.Create(cartype, listTaxCar, taxCarTody, taxWeekDays, taxidenterAndExit, Holaday, HoladayNext, taxtaxLongTime, taxTime, dateCreate);


            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, NoError);
            Assert.True(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_TypeCar_WeekDayAreaNull()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30),"Rj Soft",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
            List<TaxWeekDay> taxWeekDays = new()
            {
                TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };
            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;
            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            var taxCarResult = TaxCarArea.Create(cartype, listTaxCar, taxCarTody, null, taxidenterAndExit, Holaday, HoladayNext, taxtaxLongTime, taxTime, dateCreate);


            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.NotEqual(result.error.idCode, (int)ErrorDomainTypes.WeekDayAreaNull);
            Assert.True(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_WeekDayAreaNoTax()
        {
            // Arrange
            var dateCreate = new DateTime(2013, 2, 1, 10, 15, 30);
            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;
          
            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);
            
            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidenterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.WeekDayAreaNoTax);
            Assert.False(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_TaxLongTermArea()
        {
            // Arrange
          
            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = true;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidenterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.TaxLongTermArea);
            Assert.False(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_HolidaysToday()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidenterAndExit = 60;
            bool Holaday = true;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidenterAndExit,
                Holaday ,
                HoladayNext ,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal( result.error.idCode , (int) ErrorDomainTypes.HolidaysToday);
            Assert.False( result.IsSuccess );
        }


        [Fact]
        public async Task text_Domain_TaxCar_HolidaysTomorrow()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = true;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidenterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.HolidaysTomorrow);
            Assert.False(result.IsSuccess);
        }



        [Fact]
        public async Task text_Domain_TaxCar_TaxCarlastTodayNull()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };

            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidenterAndExit = 60;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidenterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.NotEqual(result.error.idCode, (int)ErrorDomainTypes.TaxCarlastTodayNull);
            Assert.True(result.IsSuccess);
        }


        [Fact]
        public async Task text_Domain_TaxCar_TaxCarlastTaxNotLimait()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidEnterAndExit = 0;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidEnterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.NotEqual(result.error.idCode, (int)ErrorDomainTypes.TaxCarlastTaxNotLimait);
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async Task text_Domain_TaxCar_TaxCarlastTodayNotContanTax()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry, idCarTyps, idCity, "Noramal", isActive_Yes, isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidEnterAndExit = 0;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidEnterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.NotEqual(result.error.idCode, (int)ErrorDomainTypes.TaxCarlastTodayNotContanTax);
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public async Task text_Domain_TaxCar_CarTypesTaxTimeNull()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry,
                idCarTyps,
                idCity,
                "Noramal",
                isActive_Yes,
                isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 50;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidEnterAndExit = 0;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidEnterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                null,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.CarTypesTaxTimeNull);
            Assert.False(result.IsSuccess);


        }

        [Fact]
        public async Task text_Domain_TaxCar_LimaitTaxTodayZero()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry,
                idCarTyps,
                idCity,
                "Noramal",
                isActive_Yes,
                isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 0;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidEnterAndExit = 10;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidEnterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.LimaitTaxTodayZero);
            Assert.True(result.IsSuccess);


        }


        [Fact]
        public async Task text_Domain_TaxCar_Todaystaxceiling()
        {
            // Arrange

            var cartype = CarType.Create(idPublicEntry,
                idCarTyps,
                idCity,
                "Noramal",
                isActive_Yes,
                isTax_Yes);
            List<TaxCar> listTaxCar = new()
            {
              TaxCar.Create(idPublicEntry  ,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax1),
              TaxCar.Create(idPublicEntry_2,new DateTime(2013,2,1,10,15,30)," Rj Soft ",idCar,idArea,Tax2)
            };
            decimal taxCarTody = 3;

            List<TaxWeekDay> taxWeekDays = new()
            {
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[3],Tax2,isActive_Yes,idArea),
                 TaxWeekDay.Create(idPublicEntry_2,WeekDay[4],Tax2,isActive_Yes,idArea)
            };

            int taxidEnterAndExit = 10;
            bool Holaday = false;
            bool HoladayNext = false;
            bool taxtaxLongTime = false;

            TaxTime taxTime = TaxTime.Create(idPublicEntry, new TimeSpan(10, 11, 12), new TimeSpan(10, 11, 12), idArea, Tax1);

            var taxCarResult = TaxCarArea
                .Create(
                cartype,
                listTaxCar,
                taxCarTody,
                taxWeekDays,
                taxidEnterAndExit,
                Holaday,
                HoladayNext,
                taxtaxLongTime,
                taxTime,
                dateCreate
                );

            // Act
            var result = taxCarResult.TaxCarAreaContract();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.error.idCode, (int)ErrorDomainTypes.Todaystaxceiling);
            Assert.False(result.IsSuccess);


        }

    }

}

