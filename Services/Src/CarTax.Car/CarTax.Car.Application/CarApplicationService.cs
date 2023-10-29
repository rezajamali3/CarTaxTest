
using CarTax.Car.Domain;
using CarTax.Car.Domain.Repository;
using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Interface;
using Library_EF;
using static CarTax.Car.Message.Commands;

namespace CarTax.Car.Application
{
    public class CarApplicationService : IApplicationService
    {
        private  ICarRepository _repository;
        private  IUnitOfWork    _unitOfWork;
      
        public CarApplicationService(
            ICarRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) =>  command switch
        {
                V1.NewCar cmd =>
                    HandleCreate(cmd),
                V1.ChanchDetailsCar cmd =>
                    HandleUpdate(  cmd.Id, c => c.ChanchDetilsCar(cmd.Id, cmd.CarTypeId,cmd.CarName,cmd.CodePlack,cmd.CarName,cmd.IsActive) ),
                V1.CarActive cmd =>
                    HandleUpdate( cmd.Id, c => c.CarActive() ),
                V1.CarDeActive cmd =>
                    HandleUpdate( cmd.Id, c => c.CarDeActive( ) ),
                V1.CarDelete cmd =>
                    HandleDelete( cmd.Id, c => c.CarDelete() ),
                _ => Task.CompletedTask
       };

        private async Task HandleCreate(V1.NewCar cmd)
        {
          
            var car = Cars
                   .Create(
                   
                    cmd.CarTypeId,
                    CarName
                   .Create(Name.Create(cmd.CarName)),
                    Plack
                   .Create(cmd.CodePlack,cmd.NumberPlack),
                    true
                 );

            await _repository.AddAsync(car);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            int carid,
            Action<Cars> operation
        )
        {
            var Car = await _repository
                .Load( CarId.Create( carid ));

            if (Car == null)
                throw new InvalidOperationException( $"Entity with id { carid } cannot be found");

            operation(Car);

            await _unitOfWork.Commit();
        }

        private async Task HandleDelete(
          int carid,
          Action<Cars> operation
      )
        {
            var Car = await _repository
                .Load(CarId.Create(carid));

            if (Car is null)
                throw new InvalidOperationException($"Entity with id {carid} cannot be found");

            operation(Car);

            await _repository.DeleteAsync(Car);
            await _unitOfWork.Commit();
        }



    }
}