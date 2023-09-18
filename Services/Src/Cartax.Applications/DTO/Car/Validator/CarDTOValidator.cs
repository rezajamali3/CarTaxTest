using Cartax.Applications.DTO.Car.IContract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car.Validator
{
    public class CarDTOValidator : AbstractValidator<ICarDTO>
    {
        public CarDTOValidator() 
        {


            RuleFor(p => p.CarName)
                   .NotEmpty().WithMessage("نام خالی است")
                   .NotNull().WithMessage("نام ارسال نشده است")
                   .MaximumLength(50).WithMessage("طول نام ماشین  نام زیاد است حداکثر 50");


            RuleFor(p => p.IdCarType)
               .NotEmpty().WithMessage("روز خالی است")
                .GreaterThan(0).WithMessage("کد ماشین باید بیشتر از صفر باشد");
               


        }
    }
}
