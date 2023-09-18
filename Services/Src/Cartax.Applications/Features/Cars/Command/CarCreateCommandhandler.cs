using AutoMapper;
using Cartax.Applications.Common.Base;
using Cartax.Applications.Common.Execeptions;
using Cartax.Applications.Common.Primitives;
using Cartax.Applications.DTO.Car.Validator;
using Cartax.Applications.Persistence.Repositories;
using Cartax.Applications.Services.TaxCarServices.Command;
using Cartax.Domain.Entites.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Features.Cars.Command
{
    public class CarCreateCommandhandler : ICommandHandler<CarCreateCommand>
    {

        private readonly ICarRepository CarRepository;
        private readonly IMapper mapper;

        public CarCreateCommandhandler(ICarRepository carRepository, IMapper mapper)
        {
            this.CarRepository = carRepository;
            this.mapper = mapper;
        }


        public async Task<CommandResponse> Handle(CarCreateCommand request, CancellationToken cancellationToken)
        {
            var ResponseBase = new CommandResponse(false,Error.None.Message);
            var validtor = new CarCreateDTOValidator();
            var validtorResult = await validtor.ValidateAsync(request.car);

            if (validtorResult.IsValid == false)
            {
                //throw new ValidtorExecptions(validtorResult);

                ResponseBase.ResponseFaild(" ناموفق", validtorResult.Errors.Select(p => p.ErrorMessage).ToList());
                return ResponseBase;
            }

            var car = mapper.Map<Car>(request.car);
            var result = await CarRepository.AddAsync(car);
            ResponseBase.ResponseSuccess(" موفق", validtorResult.Errors.Select(p => p.ErrorMessage).ToList());
            return ResponseBase;
        }
    }
}
