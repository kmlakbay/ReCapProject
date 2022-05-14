using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            //product.description
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p=>p.Description).MinimumLength(2);
            RuleFor(p => p.Description).Must(EndsWithDot).WithMessage("Açıklama .'yla bitmeli");

            //product.ModelYear
            RuleFor(p=>p.ModelYear).NotEmpty();

            //product.DailyPrice
            RuleFor(p=>p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(100);

            //product.BrandId
            RuleFor(p => p.BrandId).NotEmpty();

            //Product.ColorId
            RuleFor(p => p.ColorId).NotEmpty();

        }

        private bool EndsWithDot(string arg)
        {
            return arg.EndsWith(".");
        }
    }
}
