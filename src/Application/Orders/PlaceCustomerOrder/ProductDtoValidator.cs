using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Orders.PlaceCustomerOrder
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            this.RuleFor(x => x.Quantity).GreaterThan(0)
                .WithMessage("At least one product has invalid quantity");
        }
    }
}