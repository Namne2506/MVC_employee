using AppData.Data;


namespace AppAPI.Repository.Repos
{
    public interface IEmployeeRepos
    {
        public IEnumerable<Employee> GetAll();

        Task<Employee> GetEmployeeByIdAsync(int employeeId);

        Task<bool> CreateEmployeeAsync(Employee employee);
        public bool Update(Employee employee);
        public bool Delete(Employee employee);
    }
}
