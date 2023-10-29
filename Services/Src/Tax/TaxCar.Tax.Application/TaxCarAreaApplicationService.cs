
using CarTax.Tax.Domain;
using CarTax.Tax.Domain.Repositorys;
using CarTax.Tax.Domain.ValueObjects;
using Library_Domain.Interface;
using Library_EF;
using static TaxCar.Tax.Message.Commands;

namespace TaxCar.Tax.Application
{
    public class TaxCarAreaApplicationService : IApplicationService
    {


        private ITaxCarAreaRepository _repository;
        private  IUnitOfWork    _unitOfWork;
      
        public TaxCarAreaApplicationService
        (
            ITaxCarAreaRepository repository, 
            IUnitOfWork unitOfWork
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(object command) =>  command switch
        {
                 V1.newTax cmd =>
                    HandleCreate(cmd),
               
                V1.DeleteTax cmd =>
                    HandleDelete( cmd.TaxCarId, c => c.DeleteTax() ),
                _ => Task.CompletedTask
       };

        private async Task HandleCreate(V1.newTax cmd)
        {
          

            var car = TaxCarArea
                   .Create(cmd.CreateDate, cmd.Areaid, cmd.CarId, cmd.Tax, cmd.CombinedcameranumberId);

            await _repository.AddAsync(car);
            await _unitOfWork.Commit();

        }

       

        private async Task HandleDelete(
          Guid TaxCarId,
          Action<TaxCarArea> operation
      )
        {
            var Car = await _repository
                .Load(TaxCarAreaId.Create(TaxCarId));

            if (Car is null)
                throw new InvalidOperationException($"Entity with id {TaxCarId} cannot be found");

            operation(Car);

            await _repository.DeleteAsync(Car);
            await _unitOfWork.Commit();
        }



    }
}