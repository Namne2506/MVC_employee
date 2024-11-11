using AppData.Data;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository.Repos
{
    public class DepartmentRepos : IDepartmentRepos
    {
        private readonly EmployeeDbContext context;
        private readonly DbSet<Department> departments;

        public DepartmentRepos(EmployeeDbContext context, DbSet<Department> departments)
        {
            this.context = context;
            this.departments = departments;
        }

        public bool Create(Department department)
        {
            try
            {
                context.Add(department);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Department department)
        {
            try
            {
                context.Remove(department);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Department> GetAll()
        {
            return departments.ToList();
        }

        public async Task<Department> GetDepartmentByIdAsync(int departmentId)
        {
            return await context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

        public bool Update(Department department)
        {
            try
            {
                context.Update(departments);
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
