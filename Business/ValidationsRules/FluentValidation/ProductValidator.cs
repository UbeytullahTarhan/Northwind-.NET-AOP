using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationsRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //çoklu dil desteği var ona göre hata verir

            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //özel bir metodunuz varsa ona göre hata mesajı gönderilebilir
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün İsmi 2 den Büyük Olmalı");
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 1);

        }
    }
}
