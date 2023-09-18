using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car.Validator
{
    public class CarDeleteDTOValidator : AbstractValidator<CarDeleteDTO>
    {
        public CarDeleteDTOValidator()
        {

            RuleFor(p => p.Id)
              .LessThan(0).WithMessage("مقدار باید بیشتر از صفر باشد")
              .NotNull().WithMessage("مقدار خالی");

        }
    }
}
