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
        private  IUnitOfWork        _unitOfWork;
      
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
                    HandleDelete(cmd.id, c => c.TaxCarTypeDelete()),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(V1.NewTaxCarType cmd)
        {

            if (await _repository.Exists(CarTypeId.Create(cmd.id)))
                throw new InvalidOperationException(
                    $"Entity with id {cmd.id} already exists"
                );



            var cartype = CarTypes.Create(
                     CarTypeId.Create(cmd.id),
                    TypeCarName.Create(Name.Create(cmd.carName)),
                   true,
                   true);

            await _repository.AddAsync(cartype);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            byte? carTypeId,
            Action<CarTypes> operation
        )
        {
            var carType = await _repository.Load(CarTypeId.Create( carTypeId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {carTypeId} cannot be found"
                );

            operation(carType);


            await _unitOfWork.Commit();
        }


        private async Task HandleDelete(byte? carTypeId,
            Action<CarTypes> operation)
        {

            var carType = await _repository.Load(CarTypeId.Create(carTypeId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {carTypeId} cannot be found"
                );

            operation(carType);

            await _repository.DeleteAsync(carType);
            await _unitOfWork.Commit();

        }
    }
}