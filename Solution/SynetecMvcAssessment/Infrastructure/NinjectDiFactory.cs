using InterviewTestTemplatev2.BusinessLayer;
using InterviewTestTemplatev2.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Infrastructure
{
    public class NinjectDiFactory : NinjectModule
    {
        public override void Load()
        {
            //DI bindings here     
            Bind<IBonusPoolCalculatorModel>().To<BonusPoolCalculatorModel>();
            Bind<IBonusPoolCalculatorResultModel>().To<BonusPoolCalculatorResultModel>();
            Bind<IBonusAllocationService>().To<BonusAllocationService>();
        }
    }
}