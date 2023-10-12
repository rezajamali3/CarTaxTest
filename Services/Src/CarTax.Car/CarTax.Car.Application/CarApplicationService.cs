using System;
using System.Threading.Tasks;
using CarTax.Car.Domain;
using CarTax.Car.Domain.Repository;
using CarTax.Car.Domain.ValueObjects;
using Library_Domain.Interface;
using static CarTax.Car.Message.Commands;
using static CarTax.Car.Message.Events.V1;

namespace CarTax.Car.Application
{
    public class CarApplicationService : IApplicationService
    {
        private  ICarRepository _repository;
        private  IUnitOfWork _unitOfWork;
      
        public CarApplicationService(
            ICarRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) => 
            command switch
            {
                V1.NewCar cmd =>
                    HandleCreate(cmd),
                //V1.SetTitle cmd =>
                //    HandleUpdate(
                //        cmd.Id,
                //        c => c.SetTitle(
                //            ClassifiedAdTitle
                //                .FromString(cmd.Title)
                //        )
                //    ),
                //V1.UpdateText cmd =>
                //    HandleUpdate(
                //        cmd.Id,
                //        c => c.UpdateText(
                //            ClassifiedAdText.FromString(cmd.Text)
                //        )
                //    ),
                //V1.UpdatePrice cmd =>
                //    HandleUpdate(
                //        cmd.Id,
                //        c => c.UpdatePrice(
                //            Price.FromDecimal(
                //                cmd.Price,
                //                cmd.Currency,
                //                _currencyLookup
                //            )
                //        )
                //    ),
                //V1.RequestToPublish cmd =>
                //    HandleUpdate(
                //        cmd.Id,
                //        c => c.RequestToPublish()
                //    ),
                //V1.Publish cmd =>
                //    HandleUpdate(
                //        cmd.Id, c =>
                //            c.Publish(new UserId(cmd.ApprovedBy))
                //    ),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(V1.NewCar cmd)
        {
            //if (await _repository.Exists(cmd.Id.ToString()))
            //    throw new InvalidOperationException(
            //        $"Entity with id {cmd.Id} already exists"
            //    );

          //var cartype=   cartype.Create(
          //       CarTypeId.Create(2),
          //        NameTypeCar.Create(Name.Create(cmd.carName)),
          //       true,
          //       true);

            var plack = Plack.Create("48", $"12{"?"}12");

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
            Guid classifiedAdId,
            Action<Cars> operation
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