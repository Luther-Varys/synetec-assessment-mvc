using InterviewTestTemplatev2.BusinessLayer;
using InterviewTestTemplatev2.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace InterviewTestTemplatev2.Infrastructure
{
    public class NinjectControllerFactory : System.Web.Mvc.DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            //DI bindings here     
            ninjectKernel.Bind<IBonusAllocationService>().To<BonusAllocationService>();
            ninjectKernel.Bind<IMvcInterviewV3Entities1>().To<MvcInterviewV3Entities1>();
        }
    }
}