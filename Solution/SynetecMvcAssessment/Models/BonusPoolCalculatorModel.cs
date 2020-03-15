using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public interface IBonusPoolCalculatorModel
    {
        int BonusPoolAmount { get; set; }
        List<Data.HrEmployee> AllEmployees { get; set; }
        int SelectedEmployeeId { get; set; }
    }

    public class BonusPoolCalculatorModel: IBonusPoolCalculatorModel
    {
        public int BonusPoolAmount { get; set; }
        public List<Data.HrEmployee> AllEmployees { get; set; }        
        public int SelectedEmployeeId { get; set; }
    }
}