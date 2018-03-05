using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcNinjectFluentValidation.Models;
using FluentValidation;

namespace AspNetMvcNinjectFluentValidation.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {

          //  RuleFor(p => p.Id).NotEmpty(); 
            RuleFor(p => p.Description).NotNull();
            RuleFor(p => p.Summary).NotNull().MinimumLength(5).MaximumLength(25);
            //RuleFor(p => p.Summary).Length(2,20); //min 2 max 20 şeklinde 
            // burada when kullanılabilir
            //burada validationlar tutuyoruz.
            // RuleFor(p => p.tanim).Must(StartWithA);//ile kendi validationlarımızı yazabiliriz.
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

    }
   
}