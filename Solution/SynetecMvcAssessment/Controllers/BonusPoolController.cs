using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTestTemplatev2.BusinessLayer;
using InterviewTestTemplatev2.Data;
using InterviewTestTemplatev2.Infrastructure;
using InterviewTestTemplatev2.Models;
using Ninject;

namespace InterviewTestTemplatev2.Controllers
{
    public class BonusPoolController : Controller
    {
        private IBonusAllocationService _BonusAllocationService { get; set; }
        private IMvcInterviewV3Entities1 _Db { get; set; }
        private IKernel _NinjectStandardKernel { get; set; }

        public BonusPoolController(IBonusAllocationService bonusAllocationService, IMvcInterviewV3Entities1 mvcInterviewV3Entities1)
        {
            _BonusAllocationService = bonusAllocationService;
            _Db = mvcInterviewV3Entities1;
            _NinjectStandardKernel = new StandardKernel(new NinjectDiFactory());
        }

        // GET: BonusPool
        public ActionResult Index()
        {
            var model = this._NinjectStandardKernel.Get<IBonusPoolCalculatorModel>();
            model.AllEmployees = _Db.HrEmployees.ToList<HrEmployee>();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(BonusPoolCalculatorModel model)
        {
            int selectedEmployeeId = model.SelectedEmployeeId;
            int totalBonusPool = model.BonusPoolAmount;

            //load the details of the selected employee using the ID
            HrEmployee hrEmployee = (HrEmployee)_Db.HrEmployees.FirstOrDefault(item => item.ID == selectedEmployeeId);

            int employeeSalary = hrEmployee.Salary;

            //get the total salary budget for the company
            int totalSalary = (int)_Db.HrEmployees.Sum(item => item.Salary);

            //calculate the bonus allocation for the employee
            int bonusAllocation = this._BonusAllocationService
                .CalculateBonusAllocation(totalSalary, employeeSalary, totalBonusPool);

            var result = this._NinjectStandardKernel.Get<IBonusPoolCalculatorResultModel>();
            result.hrEmployee = hrEmployee;
            result.bonusPoolAllocation = bonusAllocation;

            return View(result);
        }
    }
}