using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateOnly DateOrBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public int DepartmentId {  get; set; }
        public int PositionId  { get; set; }

        public Department Department { get; set; }

        public Position Position { get; set; }

        public ICollection<SalaryBonus> SalaryBonus { get; set; }

        public ICollection<Attendance> Attendances { get; set; }

    }
}
