using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.DTO.Car.Validator
{
    public class CarUpdateDTOValidator :AbstractValidator<CarUpdateDTO>
    {
        public CarUpdateDTOValidator()
        {

            Include(new CarDTOValidator());

        }
    }
}
