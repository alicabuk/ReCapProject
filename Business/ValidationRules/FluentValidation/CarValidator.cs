using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //when koşullu yapılar için.
            //RuleFor(c => c.DailyPrice).GreaterThan(10).When(c => c.CarId == 1);

            //Olmayan metotları kendimiz yazabiliriz.
            //RuleFor(c => c.CarName).Must(StartWithA);
            //StartWithA fonksiyonunu kendimiz yazacağız.Bu class içerisinde.Bool tipi.

            //WithMessage(" ") ile kendi mesajımız verilebilir.
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
