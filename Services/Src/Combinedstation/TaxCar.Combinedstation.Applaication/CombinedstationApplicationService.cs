


using Event.Bus;
using Libraries_Helper;
using Library_Domain.Interface;
using MassTransit;
using TaxCar.Combinedstation.Applaication.Validator;
using TaxCar.Combinedstation.Core;
using TaxCar.Combinedstation.Core.Repository;
using static TaxCar.Combinedstation.Applaication.Feature.Commands;

namespace TaxCar.Combinedstation.Application
{
    public class CombinedstationApplicationService : IApplicationService
    {

        private  ICombinedStationRepository _repository;
        private readonly IPublishEndpoint _endpoint;

        public CombinedstationApplicationService(ICombinedStationRepository repository, IPublishEndpoint publishEndpoint)
        {
            _repository = repository;
            _endpoint   = publishEndpoint;
        }

        public Task Handle(object command) => command switch
               {   
                       V1.Create cmd => HandleCreate(cmd),
                       V1.Update cmd => HandleUpdate(cmd.Id, cmd),
                       V1.Delete cmd => HandleDelete(cmd),
                   _ => Task.CompletedTask 
              };

        private async Task HandleCreate(V1.Create cmd)
        {

            var validtor = new CombinedstationCreateValidator();
            var validtorResult = await validtor.ValidateAsync(cmd);

            if (validtorResult.IsValid == false)
            {
                string message = getErrorMessage(validtorResult.Errors);
                throw new Exception(message);
            }


            var microSender = new MicroSender();
            var resultAreaId = await microSender.CheckItem("api/ExistsAreaId", "AreaId", cmd.AreaId.ToString());
            if (resultAreaId == false)
            {
                throw new Exception("Not valid AreaId");
            }



            var combinedStations = new CombinedStations()
            {
                IsActive = cmd.IsActive,
                StationCode = cmd.Code,
                StationName = cmd.Name,
                AreaId = cmd.AreaId
            };


            await _repository.AddAsync(combinedStations);
            await _repository.Commit();
            await _endpoint.Publish<TestEvent>(new
            {
                TestP = 10
            });


        }

        private async Task HandleUpdate(Guid commandId, V1.Update cmd)
        {

            var validtor = new CombinedstationUpdateValidator();
            var validtorResult = await validtor.ValidateAsync(cmd);
            if (validtorResult.IsValid == false)
            {
                string message = getErrorMessage(validtorResult.Errors);
                throw new Exception(message);
            }



            var combinedStations = await _repository.Find(commandId);



            if (combinedStations is null)
                throw new InvalidOperationException($"Entity with id {commandId} cannot be found");


            combinedStations.IsActive = cmd.IsActive;
            combinedStations.StationCode = cmd.Code;
            combinedStations.StationName = cmd.Name;
            combinedStations.AreaId = cmd.AreaId;


            await _repository.Commit();

        }

        private async Task HandleDelete(V1.Delete Combinedstationdelete)
        {

            var validtor = new CombinedstationDeleteValidator();
            var validtorResult = await validtor.ValidateAsync(Combinedstationdelete);
            if ( validtorResult.IsValid == false )
            {
                string message = getErrorMessage(validtorResult.Errors);
                throw new Exception(message);
            }

            var combinedStations = await _repository.Find(Combinedstationdelete.CombinedStationsId);
            if (combinedStations is null)
                throw new InvalidOperationException($"Entity with id {Combinedstationdelete.CombinedStationsId} Cannot be Found");

            await _repository.DeleteAsync(combinedStations);
            await _repository.Commit();
        }

        private string getErrorMessage(List<FluentValidation.Results.ValidationFailure> validationFailures)
        {
            string message = string.Empty;
            foreach (string st in validationFailures.Select(a => a.ErrorMessage))
                message += st;
            return message;
        }

    }
}