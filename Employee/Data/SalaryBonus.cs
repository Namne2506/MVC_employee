using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public class SalaryBonus
    {
        public int SalaryBonusId { get; set; }
        public int EmployeeId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public float SalaryBase { get; set; }
        public float Bonus {  get; set; }
        public Employee Employee { get; set; }
    }
}
