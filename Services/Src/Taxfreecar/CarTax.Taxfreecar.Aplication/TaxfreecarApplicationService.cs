

using CarTax.AggregateRoot;
using CarTax.Taxfreecar.Domain.Repositorys;
using CarTax.Taxfreecar.Domain.ValueObjects;
using CarTax.Taxfreecar.Message;
using Library_Domain.Interface;
using Library_EF;


namespace CarTax.Taxfreecar.Aplication
{
    public class TaxfreecarApplicationService : IApplicationService
    {
        private  ITaxfreecarRepository _repository;
        private  IUnitOfWork           _unitOfWork;
      
        public TaxfreecarApplicationService(
            ITaxfreecarRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) => 
            command switch
            {
               Commands.V1.NewTaxfreecar cmd =>
                    HandleCreate(cmd),
                Commands.V1.ChancheTaxfreecar cmd =>
                    HandleUpdate( cmd.Id, c => c.ChancheTaxfreecar(cmd.Id,cmd.AreaId,cmd.TypeCarId,cmd.IsActive) ),
                Commands.V1.TaxfreecarActive cmd =>
                    HandleUpdate(cmd.Id, c => c.TaxfreecarActive()),
                Commands.V1.TaxfreecarDeActive cmd =>
                    HandleUpdate(cmd.Id, c => c.TaxfreecarDeActive()),
                Commands.V1.TaxfreecarDelete cmd =>
                    HandleDelete(cmd.Id, c => c.TaxfreecarDelete()),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(Commands.V1.NewTaxfreecar cmd)
        {

          


            var cartype = TaxFreeCar.Create(
          
                    cmd.AreaId,
                    cmd.TypeCarId,
                   cmd.IsActive
                   );

            await _repository.AddAsync(cartype);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            int TaxFreeCarId,
            Action<TaxFreeCar> operation
        )
        {
            var carType = await _repository.Load(TaxfreecarId.Create(TaxFreeCarId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {TaxFreeCarId} cannot be found"
                );

            operation(carType);


            await _unitOfWork.Commit();
        }


        private async Task HandleDelete(int TaxFreeCarId,
            Action<TaxFreeCar> operation)
        {

            var carType = await _repository.Load(TaxfreecarId.Create(TaxFreeCarId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {TaxFreeCarId} cannot be found"
                );

            operation(carType);

            await _repository.DeleteAsync(carType);
            await _unitOfWork.Commit();

        }
    }
}