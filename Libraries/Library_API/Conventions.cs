using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Marketplace.WebApi
{

    public class CommandConvention : IActionModelConvention
    {
        public void Apply(ActionModel action)
        {
            foreach (var parameter in action.Parameters)
            {
                var paramType = parameter.ParameterInfo.ParameterType;

                if (parameter.BindingInfo != null ||
                    IsSimpleType(paramType) ||
                    IsSimpleUnderlyingType(paramType))
                    continue;

                parameter.BindingInfo = new BindingInfo
                {
                    BindingSource = BindingSource.Body
                };
            }

            static bool IsSimpleType(Type type)
                => type.IsPrimitive ||
                   type == typeof(string) ||
                   type == typeof(DateTime) ||
                   type == typeof(decimal) ||
                   type == typeof(Guid) ||
                   type == typeof(DateTimeOffset) ||
                   type == typeof(TimeSpan);

            static bool IsSimpleUnderlyingType(Type type)
            {
                var underlyingType = Nullable.GetUnderlyingType(type);

                if (underlyingType != null)
                    type = underlyingType;

                return IsSimpleType(type);
            }
        }
    }
}