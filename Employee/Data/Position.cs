using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }

        public float SalaryCoefficient { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
