using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalsValidator: AbstractValidator<Rentals>
    {
        public RentalsValidator()
        {
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
        }
    }
}
