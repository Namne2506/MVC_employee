namespace AppAPI.Repository.Service
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeePositionNameAsync(int employeeId);
    }
}
