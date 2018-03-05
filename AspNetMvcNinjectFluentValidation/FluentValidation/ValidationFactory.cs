using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Ninject;
using Ninject.Modules;

namespace AspNetMvcNinjectFluentValidation.FluentValidation
{
    public class ValidationFactory : ValidatorFactoryBase
    {
        private readonly IKernel _kernel;

        public ValidationFactory(IKernel kernel)
        {
            if (kernel == null)
                throw new ArgumentNullException("NInject kernel injected is null!!");

            _kernel = kernel;
        }

        public ValidationFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }


        public override IValidator CreateInstance(Type validatorType)
        {
            return _kernel.Get(validatorType) as IValidator;
        }
    }
}