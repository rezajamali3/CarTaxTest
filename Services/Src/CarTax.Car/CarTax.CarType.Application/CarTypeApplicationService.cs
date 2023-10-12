using CarTax.Car.Application;
using CarTax.CarType.Domain;
using CarTax.CarType.Domain.Repositorys;
using CarTax.CarType.Domain.ValueObjects;
using Library_Domain.Interface;
using System;
using System.Threading.Tasks;
using static CarTax.CarType.Message.Commands;

namespace CarTax.CarType.Application
{
    public class CarTypeApplicationService : IApplicationService
    {
        private  ICarTypeRepository _repository;
        private  IUnitOfWork _unitOfWork;
      
        public CarTypeApplicationService(
            ICarTypeRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) => 
            command switch
            {
                V1.NewTaxCarType cmd =>
                    HandleCreate(cmd),
                V1.ChancheCarTypeName cmd =>
                    HandleUpdate( cmd.id, c => c.TaxCarTypeCarName(cmd.carName) ),
                V1.TaxCarTypeTaxActive cmd =>
                    HandleUpdate(cmd.id, c => c.TaxCarTypeActive()),
                V1.TaxCarTypeTaxDeActive cmd =>
                    HandleUpdate(cmd.id, c => c.TaxCarTypeDeTaxActive()),
                V1.TaxCarTypeActive cmd =>
                    HandleUpdate(cmd.id, c => c.TaxCarTypeActive()),
                V1.TaxCarTypeDeActive cmd =>
                    HandleUpdate(cmd.id, c => c.TaxCarTypeDeActive()),
                V1.TaxCarTypeDelete cmd =>
                    HandleUpdate(cmd.id, c => c.TaxCarTypeDelete()),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(V1.NewTaxCarType cmd)
        {

            if (await _repository.Exists(CarTypeId.Create(cmd.id)))
                throw new InvalidOperationException(
                    $"Entity with id {cmd.id} already exists"
                );



            //var cartype=   cartype.Create(
            //       CarTypeId.Create(2),
            //        NameTypeCar.Create(Name.Create(cmd.carName)),
            //       true,
            //       true);

            //var plack = Plack.Create("48", $"12{"?"}12");

            //var car = Cars.Create(
            //    CarId.Create( cmd.Id),
            //    cartype,

            //    CarName.Create(Name.Create( cmd.carName)),
            //    plack,
            //    true);




            //await _repository.AddAsync(car);
            //await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            byte? carTypeId,
            Action<CarTypes> operation
        )
        {
            //var classifiedAd = await _repository
            //    .Load(classifiedAdId.ToString());

            //if (classifiedAd == null)
            //    throw new InvalidOperationException(
            //        $"Entity with id {classifiedAdId} cannot be found"
            //    );

            //operation(classifiedAd);

            //await _unitOfWork.Commit();
        }
    }
}