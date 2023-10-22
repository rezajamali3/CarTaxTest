

using CarTax.City.Domain;
using CarTax.City.Domain.Repositorys;
using CarTax.City.Domain.ValueObjects;
using CarTax.City.Message;
using Library_Domain.Interface;
using Library_EF;

namespace CarTax.CarType.Application
{
    public class CityApplicationService : IApplicationService
    {
        private  ICityRepository     _repository;
        private  IUnitOfWork        _unitOfWork;
      
        public CityApplicationService(
            ICityRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) => 
            command switch
            {
                Commands.V1.NewCity cmd =>
                    HandleCreate(cmd),
                Commands.V1.ChanchDetailsCity cmd =>
                    HandleUpdate( cmd.Id, c => c.ChancheCity(cmd.CityName,cmd.CityCode,cmd.IsActive) ),
                Commands.V1.CityActive cmd =>
                    HandleUpdate(cmd.Id, c => c.CityActive()),
                Commands.V1.CityDeActive cmd =>
                    HandleUpdate(cmd.Id, c => c.CityDeActive()),
                Commands.V1.CityDelete cmd =>
                    HandleDelete(cmd.Id, c => c.CityDelete()),
                _ => Task.CompletedTask
            };

        private async Task HandleCreate(Commands.V1.NewCity cmd)
        {

            //if (await _repository.Exists(CityId.Create(cmd.id)))
            //    throw new InvalidOperationException(
            //        $"Entity with id {cmd.id} already exists"
            //    );



            var cartype = Citys.Create(
                
                    CityName.Create(Name.Create(cmd.CityName)),
                   CityCode.Create(  cmd.CityCode),
                   true);

            await _repository.AddAsync(cartype);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate(
            int cityId,
            Action<Citys> operation
        )
        {
            var carType = await _repository.Load(CityId.Create(cityId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {cityId} cannot be found"
                );

            operation(carType);


            await _unitOfWork.Commit();
        }


        private async Task HandleDelete(int cityId,
            Action<Citys> operation)
        {

            var carType = await _repository.Load(CityId.Create(cityId));

            if (carType == null)
                throw new InvalidOperationException(
                    $"Entity with id {cityId} cannot be found"
                );

            operation(carType);

            await _repository.DeleteAsync(carType);
            await _unitOfWork.Commit();

        }
    }
}