using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcNinjectFluentValidation.Models;
using FluentValidation;
using Ninject.Modules;

namespace AspNetMvcNinjectFluentValidation.FluentValidation
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}