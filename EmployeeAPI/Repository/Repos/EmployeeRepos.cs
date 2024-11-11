using AppData.Data;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository.Repos
{
    public class EmployeeRepos : IEmployeeRepos
    {
        private readonly EmployeeDbContext context;
        private readonly DbSet<Employee> employees;

        public EmployeeRepos(EmployeeDbContext context, DbSet<Employee> employees)
        {
            this.context = context;
            this.employees = employees;
        }

        public async Task<bool> CreateEmployeeAsync(Employee employee)
        {
            try
            {
                await context.Employees.AddAsync(employee);
                await context.SaveChangesAsync();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Employee employee)
        {
            try
            {
                context.Remove(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees.ToList();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int EmployeeId)
        {
            return await context.Employees.FirstAsync(e => e.EmployeeId == EmployeeId);
        }

        public bool Update(Employee employee)
        {
            try
            {
                context.Update(employee);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
