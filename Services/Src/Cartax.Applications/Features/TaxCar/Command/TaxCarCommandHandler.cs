
using AutoMapper;

using Cartax.Applications.Common.Base;
using Cartax.Applications.Persistence.Repositories;
using Cartax.Applications.Common.Primitives;
using MediatR;
using Cartax.Domain.Domain.Citys.Entitys;
using Cartax.Applications.Common.Execeptions;
using Cartax.Domain.Entites.Tax.TaxCars;

using Library_Domain.Model;
using Error = Library_Domain.Model.Error;

namespace Cartax.Applications.Services.TaxCarServices.Command
{
    public class TaxCarCommandHandler : ICommandHandler<TaxCarCommand>
    {


        //private readonly ICarTypesRepository _CarTypesRepository;
        //private readonly ICarRepository _CarRepository;


        //private readonly ITaxTaxLongTermRepository _TaxLongTermRepository;
        //private readonly ITaxPublicholidayRepository _TaxPublicholidayRepository;
        //private readonly ITaxLimitTimeRepository _TaxLimitTimeRepository;
        //private readonly ITaxLimitDayRepository _TaxLimitDayRepository;
        //private readonly ITaxTimeRepository _TaxTimeRepository;
        //private readonly ITaxCarRepository _TaxCarRepository;

        //private readonly ITaxWeekDayRepository _TaxWeekDayRepository;
        //private readonly ITaxLimitMoneyDayRepository _TaxLimitMoneyDayRepository;
        //private readonly IMapper _Mapper;
        //private readonly IMediator _Mediator;

        //public TaxCarCommandHandler
        //    (
        //ICarRepository carRepository,
        //ITaxTaxLongTermRepository taxLongTermRepository,
        //ITaxPublicholidayRepository taxPublicholidayRepository,
        //ITaxLimitTimeRepository taxLimitTimeRepository,
        //ITaxLimitDayRepository taxLimitDayRepository,
        //ITaxTimeRepository taxTimeRepository,
        //ITaxCarRepository taxCarRepository,
        ////ICarTypesRepository carTypesRepository,
        //ITaxLimitMoneyDayRepository taxLimitMoneyDayRepository,
        //ITaxWeekDayRepository taxWeekDayRepository,
        //IMapper mapper,
        //IMediator mediator
        //    )
        //{
        //    _TaxPublicholidayRepository = taxPublicholidayRepository;
        //    _TaxWeekDayRepository = taxWeekDayRepository;
        //    //_CarTypesRepository = carTypesRepository;
        //    //_CarRepository = carRepository;
        //    _TaxLongTermRepository = taxLongTermRepository;
        //    _TaxLimitTimeRepository = taxLimitTimeRepository;
        //    _TaxLimitDayRepository = taxLimitDayRepository;
        //    _TaxTimeRepository = taxTimeRepository;
        //    _TaxCarRepository = taxCarRepository;
        //    _TaxLimitTimeRepository = taxLimitTimeRepository;
        //    _TaxCarRepository = taxCarRepository;
        //    _TaxLimitMoneyDayRepository =taxLimitMoneyDayRepository;
        //    _Mapper = mapper;
        //    _Mediator = mediator;
        //}

        //public async Task<CommandResponse> Handle(TaxCarCommand request, CancellationToken cancellationToken)
        //{

        //    var Car = await GetCar(request.idCar);
        //    if (Car == null)
        //        return new CommandResponse(false, string.Empty);

        //    var carType = await GetCarTypes(request.idCar);

        //    if (carType is null)
        //        return new CommandResponse(false, string.Empty);



        //    var ListTaxCarToday = await GetTaxCarEndTodayAll(request.idCar, request.idArea,request.CreateTime);

        //    var TaxCarEndToday = await GetTaxCarEndToday(request.idCar, request.idArea);

        //    var taxLimitmoneyDay = await GetTaxLimitMoneyToday(Car.Id);

        //    var taxWeeks = await GetTaxWeekDay(request.idArea);

        //    int taxLimitTimeEnterandExit =await GetTaxLimitTime(request.idArea);

        //    var isPublicholidayToday = await GetPublicholidayToday(request.CreateTime);

        //    var isPublicholidayNextDay = await GetPublicholidayNext(request.CreateTime);

        //    var isTaxLongTerm =await GetTaxLongTerm(request.idArea,request.CreateTime);

        //    var CurentTaxTime = await GetTaxTime(request.idArea,request.CreateTime);



        //    var taxcarArea =  TaxCarArea.Create(
        //        carType,
        //        ListTaxCarToday,
        //        taxLimitmoneyDay,
        //        taxWeeks,
        //        taxLimitTimeEnterandExit,
        //        isPublicholidayToday,
        //        isPublicholidayNextDay,
        //        isTaxLongTerm,
        //        CurentTaxTime,
        //        request.CreateTime
        //        );

        //    var domainResult =  taxcarArea.TaxCarAreaContract();

        //    CommandResponse command ;

        //    if (domainResult.IsSuccess == true)
        //    {

        //        command = await NewInserTaxCar(request, domainResult);

        //        return command;

        //    }

        //    command = new CommandResponse(false, domainResult.error.Message);


        //    return command;
        //}


        //private async Task<CommandResponse> NewInserTaxCar(TaxCarCommand taxCarCommand, DomainResult domainResult)
        //{


        //    if (taxCarCommand is null)
        //    {
        //        domainResult.SetData(false, Error.NullValue);
        //    }

        //    if (domainResult is null)
        //    {
        //        domainResult.SetData(false, Error.NullValue);
        //    }

        //    TaxCar tax = TaxCar.Create(
        //        default,
        //        taxCarCommand.CreateTime,
        //        "",
        //        taxCarCommand.idArea,
        //        taxCarCommand.idCar ,
        //        (decimal)domainResult.Data
        //    );

        //     var result=   await _TaxCarRepository.AddAsync(tax);
        //    if (result != 0)
        //    {
        //        domainResult.SetData(true, Error.None);
        //        return new CommandResponse(domainResult.IsSuccess, $" {domainResult.Data} درج مالیات ");
        //    }

        //    return new CommandResponse(false,"خطا در ذخیره سازی مالیت منطق شهری");
        //}


        //private async Task<TaxTime?> GetTaxTime(int idArea, DateTime dateTime)
        //{
        //    string formattedTime = dateTime.ToString("HH:mm:ss");
        //    TimeSpan currentTimeSpan = TimeSpan.Parse(formattedTime);
        //    var Publicholiday = await _TaxTimeRepository.GetAsync(a =>
        //    a.Idarea == idArea &&
        //    a.EndDate >= currentTimeSpan &&
        //    a.StartDate <= currentTimeSpan
        //    );

        //    return Publicholiday;
        //}

        //private async Task<bool> GetTaxLongTerm(int idArea,DateTime datecreate)
        //{


        //    var Publicholiday = await _TaxLongTermRepository.GetAsync(a => 
        //    a.IdArea == idArea && 
        //    a.DayEnd >= datecreate.Date && 
        //    a.DayStart <= datecreate.Date 
        //    );

        //    if (Publicholiday is null)
        //        return false;

        //    return true;
        //}

        //private async Task<bool> GetPublicholidayNext(DateTime? datecreate)
        //{

        //    DateTime dateTime = datecreate.Value.AddDays(1);
        //    DateTime dateWithoutTime = dateTime.Date;

        //    var Publicholiday = await _TaxPublicholidayRepository.GetAsync(a => a.Day.Value.Date == dateWithoutTime.Date );

        //    if (Publicholiday is null)
        //        return false;

        //    return true;
        //}

        //private async Task<bool> GetPublicholidayToday(DateTime? datecreate)
        //{
        //    var Publicholiday = await _TaxPublicholidayRepository
        //        .GetAsync(a => a.Day.Value.Date == datecreate.Value.Date );

        //    if(Publicholiday is null )
        //    return false;

        //    return true;
        //}

        //private async Task<int> GetTaxLimitTime(int idArea)
        //{
        //    var TaxLimitTime = await _TaxLimitTimeRepository.GetAsync(a => a.Id == idArea);

        //    double? totalMinutes = TaxLimitTime.Time?.TotalMinutes; 

        //    int minutes = (int)Math.Floor((double)totalMinutes);
        //    return minutes;
        //}

        //private async Task<List<TaxWeekDay>?> GetTaxWeekDay(int idArea)
        //{
        //    var taxWeekDay = await _TaxWeekDayRepository.ListAsync(a => a.IdArea == idArea);
        //    return taxWeekDay;
        //}

        //private async Task<decimal>      GetTaxLimitMoneyToday(int? idArea)
        //{
        //    TaxLimitMoneyDay taxLimitmoneyDay = await _TaxLimitMoneyDayRepository.GetAsync(a => a.IdArea == idArea);
        //    return (decimal)taxLimitmoneyDay.Tax;
        //}



        ////private async Task<Car>          GetCar(int id)
        ////{
        ////    var Car = await _CarRepository.GetAsync(a => a.Id == id);
        ////    return Car;
        ////}

        //private async Task<List<TaxCar>> GetTaxCarEndTodayAll(
        //    int? idCar,
        //    int? idarea,
        //    DateTime Datecreate
        //    )
        //{
        //    var taxCarTodayAll = await _TaxCarRepository.ListAsync(
        //       a => a.Idcar == idCar &&
        //       a.Idarea == idarea &&
        //       a.CreateDate.Value.Date == Datecreate.Date);

        //    return taxCarTodayAll;
        //}

        //private async Task<TaxCar>       GetTaxCarEndToday(int? idCar ,int? idarea)
        //{
        //    var taxCarToday = await _TaxCarRepository.GetTaxCarEndToday(idCar, idarea);
        //    return taxCarToday;
        //}

        //public Task<CommandResponse> Handle(TaxCarCommand request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //private async Task<CarType?>     GetCarTypes(int idCar)
        //{
        //    CarType? carTypes = await _CarTypesRepository.GetAsync(a => a.Id == idCar);
        //    return carTypes;
        //}
        public Task<CommandResponse> Handle(TaxCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
