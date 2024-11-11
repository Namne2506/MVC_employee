
using AppAPI.Repository.Repos;

namespace AppAPI.Repository.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepos _employeeRepos;
        private readonly IPositionRepos _positionRepos;

        public EmployeeService(IEmployeeRepos employeeRepos, IPositionRepos positionRepos)
        {
            _employeeRepos = employeeRepos;
            _positionRepos = positionRepos;
        }

        public async Task<string> GetEmployeePositionNameAsync(int employeeId)
        {
            var position = await _employeeRepos.GetEmployeeByIdAsync(employeeId);
            if(position == null)
            {
                throw new Exception("Khong the tim thay nhan vien nay");
            }
            return position.EmployeeName;
        }
    }
}
