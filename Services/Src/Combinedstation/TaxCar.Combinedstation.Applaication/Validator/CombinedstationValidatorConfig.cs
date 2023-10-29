using FluentValidation;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxCar.Combinedstation.Applaication.Feature.Commands;


namespace TaxCar.Combinedstation.Applaication.Validator;



public class CombinedstationDeleteValidator : AbstractValidator<V1.Delete>
{

    public CombinedstationDeleteValidator()
    {

        RuleFor(p => p.CombinedStationsId)
                     .NotNull()
                     .WithMessage("The Combined StationsId is empty");

    }

}

public class CombinedstationUpdateValidator : AbstractValidator<V1.Update>
{
    public CombinedstationUpdateValidator()
    {

        Include(new CombinedstationCreateValidator());

        RuleFor(p => p.Id)
                     .NotNull()
                     .WithMessage("The Combined StationsId is empty");

    }
}


public class CombinedstationCreateValidator : AbstractValidator<ICombinedstationValidatorConfig>
{
    public CombinedstationCreateValidator()
    {


        RuleFor(p => p.Code)
               .NotEmpty().WithMessage("The StationCode is empty")
               .NotNull().WithMessage("StationCode not sent")
               .MaximumLength(3).WithMessage("less than 3 StationCode");


        RuleFor(p => p.Name)
             .NotEmpty().WithMessage(" The Station Name is empty ")
             .NotNull().WithMessage(" Station Name not sent ")
             .MaximumLength(60).WithMessage(" less than 60 StationName ");

        RuleFor(p => p.AreaId)
                   .NotNull()
                   .WithMessage("The AreaId is not empty");

    }
}

public interface ICombinedstationValidatorConfig
{
    public string Name { get; set; }

    public int AreaId { get; set; }

    public string Code { get; set; }

    public bool IsActive { get; set; }
}

