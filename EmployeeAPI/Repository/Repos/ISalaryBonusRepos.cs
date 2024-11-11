using AppData.Data;

namespace AppAPI.Repository.Repos
{
    public interface ISalaryBonusRepos
    {
        public IEnumerable<SalaryBonus> GetAll();
        Task<bool> CreateAsync(SalaryBonus salaryBonus);
        
        public bool Update(SalaryBonus salaryBonus);
        public bool Delete(SalaryBonus salaryBonus);


        
    }
}
