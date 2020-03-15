using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Infrastructure.Exceptions
{
    public class TotalSalaryCannotBeNegativeException : Exception
    {
        public TotalSalaryCannotBeNegativeException()
        {
        }

        public TotalSalaryCannotBeNegativeException(string message)
            : base(message)
        {
        }

        public TotalSalaryCannotBeNegativeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class EmployeeSalaryCannotBeNegativeException : Exception
    {
        public EmployeeSalaryCannotBeNegativeException()
        {
        }

        public EmployeeSalaryCannotBeNegativeException(string message)
            : base(message)
        {
        }

        public EmployeeSalaryCannotBeNegativeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class TotalBonusPoolCannotBeNegativeException : Exception
    {
        public TotalBonusPoolCannotBeNegativeException()
        {
        }

        public TotalBonusPoolCannotBeNegativeException(string message)
            : base(message)
        {
        }

        public TotalBonusPoolCannotBeNegativeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class EmployeeSalaryIsGreaterThanTotalSalaryException : Exception
    {
        public EmployeeSalaryIsGreaterThanTotalSalaryException()
        {
        }

        public EmployeeSalaryIsGreaterThanTotalSalaryException(string message)
            : base(message)
        {
        }

        public EmployeeSalaryIsGreaterThanTotalSalaryException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}