

using TaxCar.Publicholidays.Message;
using Library_Domain.Interface;
using Library_EF;
using TaxCar.Publicholidays.Domain.Repository;
using TaxCar.Publicholiday.Domain.ValueObjects;

namespace CarTax.Publicholiday.Application
{
    public class PublicholidayApplicationService : IApplicationService
    {
        private IPublicholidayRepository _repository;
        private  IUnitOfWork             _unitOfWork;
      
        public PublicholidayApplicationService(
            IPublicholidayRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) => 
            command switch
            {
                Commands.V1.Definitionofpublicholidays cmd =>
                    HandleCreate(cmd),
                Commands.V1.ChanchDetailsofpublicholidays cmd =>
                    HandleUpdate(cmd.PublicholidayId, c => 
                    c.ChanchDetailsofpublicholidays( cmd.Day, cmd.AreaId, cmd.IsActive) ),
                Commands.V1.publicholidaysActive cmd =>
                    HandleUpdate(cmd.Id, c => c.PublicholidaysActive()),
                Commands.V1.publicholidaysDeActive cmd =>
                    HandleUpdate(cmd.Id, c => c.PublicholidaysDeActive()),
                Commands.V1.Deleteofpublicholidays cmd =>
                    HandleDelete(cmd.PublicholidayId, c => c.Deleteofpublicholidays()),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(Commands.V1.Definitionofpublicholidays cmd)
        {

            var cartype = TaxCar.Publicholidays.Publicholiday.Create(cmd.Day,cmd.AreaId, cmd.IsActive);

            await _repository.AddAsync(cartype);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            int publicholidayId,
            Action<TaxCar.Publicholidays.Publicholiday> operation
        )
        {
            var publicholiday = await _repository.Load(PublicholidayId.Create(publicholidayId));

            if (publicholiday == null)
                throw new InvalidOperationException(
                    $" Entity with id {publicholidayId} Cannot Be Found "
                );

            operation(publicholiday);


            await _unitOfWork.Commit();
        }


        private async Task HandleDelete(int publicholidayId,
            Action<TaxCar.Publicholidays.Publicholiday> operation)
        {

            var publicholiday = await _repository.Load(PublicholidayId.Create(publicholidayId));

            if (publicholiday == null)
                throw new InvalidOperationException(
                    $"Entity with id {publicholidayId} cannot be found"
                );

            operation(publicholiday);

            await _repository.DeleteAsync(publicholiday);
            await _unitOfWork.Commit();

        }
    }
}