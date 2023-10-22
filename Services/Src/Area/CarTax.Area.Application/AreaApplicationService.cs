using CarTax.Area.Domain.Repository;
using CarTax.Area.Domain.ValueObjects;
using CarTax.Area.Application;
using Library_API.EventSoursing;
using Library_EF;
using CarTax.Area.Message;
using CarTax.Area.Domain;
using static CarTax.Area.Message.Commands;

namespace CarTax.Area.Application
{
    public class AreaApplicationService : IApplicationService
    {

        private  IAreaRepository _repository;
        private  IUnitOfWork    _unitOfWork;
      
        public AreaApplicationService(
            IAreaRepository repository, 
            IUnitOfWork unitOfWork
        )
        {

            _repository = repository;
            _unitOfWork = unitOfWork;
         
        }

        public Task Handle(object command) =>  command switch
        {
           V1.NewArea cmd =>
                    HandleCreate(cmd),
            V1.ChanchDetailsArea cmd =>
                    HandleUpdate( cmd.Id, c => c.ChancheArea( cmd.AreaName,cmd.AreaCode,cmd.Maximumdailytaxamount, cmd.CityId,cmd.LimitedMinutes, cmd.IsActive)),
           V1.AreaActive cmd =>
                    HandleUpdate( cmd.Id, c => c.AreaActive() ),
          V1.AreaDeActive cmd =>
                    HandleUpdate( cmd.Id, c => c.AreaDeActive( ) ),
           V1.AreaDelete cmd =>
                    HandleDelete( cmd.Id, c => c.AreaDelete() ),


            V1.Newspecifiedhourstax cmd =>
                   HandleUpdate(cmd.AreaId, c => c.Newspecifiedhourstax(cmd.StartDate,cmd.EndDate,cmd.Tax,cmd.AreaId)),
           V1.Deletespecifiedhourstax cmd =>
                  HandleDelete(cmd.AreaId, c => c.Deletespecifiedhourstax(cmd.specifiedhourstaxId)),


           V1.NewTaxfreecar cmd =>
           HandleDelete(cmd.AreaId, c => c.NewTaxfreecar( cmd.AreaId, cmd.TypeCarId, cmd.IsActive)),

           V1.ChancheTaxfreecar cmd =>
            HandleDelete(cmd.AreaId, c => c.ChancheTaxfreecar(cmd.AreaId,cmd.TypeCarId,cmd.IsActive)),

            V1.TaxfreecarDeActive cmd =>
               HandleDelete(cmd.AreaId, c => c.TaxfreecarDeActive(cmd.Id)),

           V1.TaxfreecarActive cmd =>
                 HandleDelete(cmd.AreaId, c => c.TaxfreecarActive(cmd.Id)),

           V1.TaxfreecarDelete cmd =>
                 HandleDelete(cmd.AreaId, c => c.TaxfreecarDelete(cmd.Id)),

            _ => Task.CompletedTask
       };

       
      
        private async Task HandleCreate(V1.NewArea cmd)
        {

            if (await _repository.Exists(AreaId.Create(cmd.Id)))
                throw new InvalidOperationException(  $"Entity with id {cmd.Id} already exists" );



            var car = Areas.Create
                  (
                    cmd.Id,
                    cmd.AreaName,
                    cmd.AreaCode,
                    cmd.Maximumdailytaxamount ,
                    cmd.CityId,
                    cmd.LimitedMinutes,
                    cmd.IsActive
                 );

            await _repository.AddAsync(car);
            await _unitOfWork.Commit();

        }

        private async Task HandleUpdate( int Areaid, Action<Areas> operation )
        {
            var area = await _repository
                .Load( AreaId.Create(Areaid));

            if (area == null)
                throw new InvalidOperationException( $"Entity with id {Areaid} cannot be found");

            operation(area);

            await _unitOfWork.Commit();
        }

        private async Task HandleDelete(int carid, Action<Areas> operation)
        {
            var Car = await _repository
                .Load(AreaId.Create(carid));

            if (Car is null)
                throw new InvalidOperationException($"Entity with id {carid} cannot be found");

            operation(Car);

            await _repository.DeleteAsync(Car);
            await _unitOfWork.Commit();
        }



    }
}