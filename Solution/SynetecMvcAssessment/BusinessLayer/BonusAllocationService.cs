using InterviewTestTemplatev2.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.BusinessLayer
{
    public interface IBonusAllocationService
    {
        int CalculateBonusAllocation(int totalSalary, int employeeSalary, int totalBonusPool);
    }


    public class BonusAllocationService : IBonusAllocationService
    {
        /// <summary>
        /// totalSalary: the sum of all employees salaries
        /// employeeSalary: the salary for a single employee
        /// totalBonusPool: the bonul pool that needs to be devides among employees
        /// </summary>
        /// <param name="totalSalary"></param>
        /// <param name="employeeSalary"></param>
        /// <param name="totalBonusPool"></param>
        /// <returns></returns>
        public int CalculateBonusAllocation(int totalSalary, int employeeSalary, int totalBonusPool)
        {

            if (totalSalary < 0)
            {
                throw new TotalSalaryCannotBeNegativeException("ZR: totalSalary cannot be less than 0");
            }
            if (employeeSalary < 0)
            {
                throw new EmployeeSalaryCannotBeNegativeException("ZR: employeeSalary cannot be less than 0");
            }
            if (totalBonusPool < 0)
            {
                throw new TotalBonusPoolCannotBeNegativeException("ZR: totalBonusPool cannot be less than 0");
            }
            if (employeeSalary > totalSalary)
            {
                throw new EmployeeSalaryIsGreaterThanTotalSalaryException("ZR: a single employeeSalary cannot be > than all the employees totalSalary");
            }

            decimal bonusPercentage = (decimal)employeeSalary / (decimal)totalSalary;
            int bonusAllocation = (int)(bonusPercentage * totalBonusPool);

            return bonusAllocation;
        }
    }
}