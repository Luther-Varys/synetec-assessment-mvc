using System;
using InterviewTestTemplatev2.BusinessLayer;
using InterviewTestTemplatev2.Infrastructure;
using InterviewTestTemplatev2.Infrastructure.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace SynetecMvcAssessment.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IKernel _NinjectStandardKernel { get; set; }
        private IBonusAllocationService _IBonusAllocationService { get; set; }

        public UnitTest1()
        {
            _NinjectStandardKernel = new StandardKernel(new NinjectDiFactory());
            this._IBonusAllocationService = this._NinjectStandardKernel.Get<IBonusAllocationService>();
        }

        [TestMethod]
        public void Negative_TotalSalary_Should_Throw_Exception()
        {
            //arrange
            int totalSalary = -200;
            int employeeSalary = 100;
            int totalBonusPool = 1000;

            try
            {
                //act
                this._IBonusAllocationService.CalculateBonusAllocation(totalSalary, employeeSalary, totalBonusPool);
            }
            catch (TotalSalaryCannotBeNegativeException ex)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Negative_EmployeeSalary_Should_Throw_Exception()
        {
            //arrange
            int totalSalary = 200;
            int employeeSalary = -100;
            int totalBonusPool = 1000;

            try
            {
                //act
                this._IBonusAllocationService.CalculateBonusAllocation(totalSalary, employeeSalary, totalBonusPool);
            }
            catch (EmployeeSalaryCannotBeNegativeException ex)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Negative_TotalBonusPool_Should_Throw_Exception()
        {
            //arrange
            int totalSalary = 200;
            int employeeSalary = 100;
            int totalBonusPool = -1000;

            try
            {
                //act
                this._IBonusAllocationService.CalculateBonusAllocation(totalSalary, employeeSalary, totalBonusPool);
            }
            catch (TotalBonusPoolCannotBeNegativeException ex)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(false);
        }

        [TestMethod]
        public void EmployeeSalary_GreaterThan_TotalaSalary_Should_Throw_Exception()
        {
            //arrange
            int totalSalary = 200;
            int employeeSalary = 1001;
            int totalBonusPool = 1000;

            try
            {
                //act
                this._IBonusAllocationService.CalculateBonusAllocation(totalSalary, employeeSalary, totalBonusPool);
            }
            catch (EmployeeSalaryIsGreaterThanTotalSalaryException ex)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(false);
        }
    }
}
