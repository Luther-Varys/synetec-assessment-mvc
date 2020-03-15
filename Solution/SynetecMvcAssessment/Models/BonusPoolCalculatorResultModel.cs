using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public interface IBonusPoolCalculatorResultModel
    {
        Data.HrEmployee hrEmployee { get; set; }
        int bonusPoolAllocation { get; set; }
    }

    public class BonusPoolCalculatorResultModel : IBonusPoolCalculatorResultModel
    {
        public Data.HrEmployee hrEmployee { get; set; }
        public int bonusPoolAllocation { get; set; }
    }
}