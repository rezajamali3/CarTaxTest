using AutoMapper;
using Cartax.Applications.DTO.Areas;
using Cartax.Applications.DTO.Car;
using Cartax.Applications.DTO.CarType;
using Cartax.Applications.DTO.TaxCars;
using Cartax.Applications.DTO.TaxLimitDays;
using Cartax.Applications.DTO.TaxLimitTime;
using Cartax.Applications.DTO.TaxLongTerms;
using Cartax.Applications.DTO.TaxPublicholidays;
using Cartax.Applications.DTO.TaxTimes;
using Cartax.Applications.DTO.TaxWeekDay;
using Cartax.Domain.Domain.Citys.Entitys;
//using Cartax.Domain.Entites.Cars;
//using Cartax.Domain.Entites.CarTypes;
using Cartax.Domain.Entites.Tax.TaxCars;

namespace Cartax.Applications.Common.Base
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            AreaProfile();


            CarProfile();

            CarTypesProfile();

            TaxCarProfile();


            TaxLimitDayProfile();

            TaxLimitTimeProfile();

            TaxPublicholidayProfile();

            TaxTaxLongTermProfile();

            TaxTimeProfile();

            TaxWeekDayProfile();
        }


        public void AreaProfile()
        {
            CreateMap<Area, TaxLimitDayDTO>().ReverseMap();

            CreateMap<Area, AreaCreateDTO>().ReverseMap();
            CreateMap<Area, AreaDeleteDTO>().ReverseMap();
            CreateMap<Area, AreaUpdateDTO>().ReverseMap();
        }


        public void CarProfile()
        {
            //CreateMap<Car, CarDTO>().ReverseMap();

            //CreateMap<Car, CarCreateDTO>().ReverseMap();
            //CreateMap<Car, CarDeleteDTO>().ReverseMap();
            //CreateMap<Car, CarUpdateDTO>().ReverseMap();
        }


        public void CarTypesProfile()
        {
            //CreateMap<CarType, CarTypesDTO>().ReverseMap();

            //CreateMap<CarType, CarTypesCreateDTO>().ReverseMap();
            //CreateMap<CarType, CarTypesDeleteDTO>().ReverseMap();
            //CreateMap<CarType, CarTypesUpdateDTO>().ReverseMap();
        }

        public void TaxCarProfile()
        {
            CreateMap<TaxCarArea, TaxCarDTO>().ReverseMap();

            CreateMap<TaxCarArea, TaxCarCreateDTO>().ReverseMap();
            CreateMap<TaxCarArea, TaxCarDeleteDTO>().ReverseMap();
            CreateMap<TaxCarArea, TaxCarUpdateDTO>().ReverseMap();
        }

        public void TaxLimitDayProfile()
        {
            CreateMap<TaxLimitDay, TaxLimitDayDTO>().ReverseMap();

            CreateMap<TaxLimitDay, TaxLimitDayCreateDTO>().ReverseMap();
            CreateMap<TaxLimitDay, TaxLimitDayDeleteDTO>().ReverseMap();
            CreateMap<TaxLimitDay, TaxLimitDayUpdateDTO>().ReverseMap();
        }

        public void TaxLimitTimeProfile()
        {
            CreateMap<TaxLimitTime, TaxLimitTimeDTO>().ReverseMap();

            CreateMap<TaxLimitTime, TaxLimitTimeCreateDTO>().ReverseMap();
            CreateMap<TaxLimitTime, TaxLimitTimeDeleteDTO>().ReverseMap();
            CreateMap<TaxLimitTime, TaxLimitTimeUpdateDTO>().ReverseMap();
        }

        public void TaxPublicholidayProfile()
        {
            CreateMap<TaxPublicholiday, TaxPublicholidayDTO>().ReverseMap();

            CreateMap<TaxPublicholiday, TaxPublicholidayCreateDTO>().ReverseMap();
            CreateMap<TaxPublicholiday, TaxPublicholidayDeleteDTO>().ReverseMap();
            CreateMap<TaxPublicholiday, TaxPublicholidayUpdateDTO>().ReverseMap();
        }

        public void TaxTaxLongTermProfile()
        {
            CreateMap<TaxTaxLongTerm, TaxTaxLongTermDTO>().ReverseMap();

            CreateMap<TaxTaxLongTerm, TaxTaxLongTermCreateDTO>().ReverseMap();
            CreateMap<TaxTaxLongTerm, TaxTaxLongTermDeleteDTO>().ReverseMap();
            CreateMap<TaxTaxLongTerm, TaxTaxLongTermUpdateDTO>().ReverseMap();
        }

        public void TaxTimeProfile()
        {
            CreateMap<TaxTime, TaxTimeDTO>().ReverseMap();

            CreateMap<TaxTime, TaxTimeCreateDTO>().ReverseMap();
            CreateMap<TaxTime, TaxTimeDeleteDTO>().ReverseMap();
            CreateMap<TaxTime, TaxTimeUpdateDTO>().ReverseMap();

        }

        public void TaxWeekDayProfile()
        {
            CreateMap<TaxWeekDay, TaxWeekDayDTO>().ReverseMap();

            CreateMap<TaxWeekDay, TaxWeekDayCreateDTO>().ReverseMap();
            CreateMap<TaxWeekDay, TaxWeekDayDeleteDTO>().ReverseMap();
            CreateMap<TaxWeekDay, TaxWeekDayUpdateDTO>().ReverseMap();
        }


    }
}
