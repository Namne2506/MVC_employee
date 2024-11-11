using AppAPI.Repository.Repos;
using AppData.Data;
using AppAPI.Exceptions;
using System.Net;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AppAPI.Repository.Service
{
    public class SalaryBonusService : ISalaryBonusService
    {
        private readonly IEmployeeRepos _employeeRepos;
        private readonly IPositionRepos _positionRepos;
        private readonly ISalaryBonusRepos _salaryBonusRepos;
        private readonly IDepartmentRepos _departmentRepos;

        public SalaryBonusService(IEmployeeRepos employeeRepos, IPositionRepos positionRepos, ISalaryBonusRepos salaryBonusRepos, IDepartmentRepos departmentRepos)
        {
            _employeeRepos = employeeRepos;
            _positionRepos = positionRepos;
            _salaryBonusRepos = salaryBonusRepos;
            _departmentRepos = departmentRepos;
        }

        public async Task<SalaryBonus> CreateSalaryBonusAsync(SalaryBonus salaryBonus)
        {
            var employee = await _employeeRepos.GetEmployeeByIdAsync(salaryBonus.EmployeeId);
            if(employee == null)
            {
                var _employee = new Employee
                {
                    EmployeeId = salaryBonus.EmployeeId,
                    EmployeeName = employee.EmployeeName,
                    DateOrBirth = employee.DateOrBirth,
                    PhoneNumber = employee.PhoneNumber,
                    DepartmentId = employee.DepartmentId,
                    PositionId = employee.PositionId,
                    Gender = employee.Gender,
                    Address = employee.Address
                };
                await _employeeRepos.CreateEmployeeAsync(employee);
            }

            var department = await _departmentRepos.GetDepartmentByIdAsync(employee.DepartmentId);
            if(department == null)
            {
                throw new ValidateException($"Department with ID {employee.DepartmentId} does not exist.");
            }
            var position = await _positionRepos.GetPositionByIdAsync(employee.PositionId);
            if(position == null)
            {
                throw new ValidateException($"Position with ID {employee.PositionId} does not exist.");
            }
                var newSalaryBonus = new SalaryBonus
                {
                    EmployeeId = salaryBonus.EmployeeId,
                    Month = salaryBonus.Month,
                    Year = salaryBonus.Year,
                    SalaryBase = salaryBonus.SalaryBase,
                    Bonus = salaryBonus.Bonus
                };

            await _salaryBonusRepos.CreateAsync(newSalaryBonus);
            return newSalaryBonus;

        }


    }
}
