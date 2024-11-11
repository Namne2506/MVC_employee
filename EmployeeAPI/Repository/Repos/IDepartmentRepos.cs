using AppData.Data;

namespace AppAPI.Repository.Repos
{
    public interface IDepartmentRepos
    {
        public IEnumerable<Department> GetAll();

        Task<Department> GetDepartmentByIdAsync(int departmentId);
        public bool Create(Department department);
        public bool Update(Department department);
        public bool Delete(Department department);

    }
}
