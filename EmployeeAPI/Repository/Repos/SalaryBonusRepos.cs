using AppData.Data;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository.Repos
{
    public class SalaryBonusRepos : ISalaryBonusRepos
    {
        private readonly EmployeeDbContext context;
        private readonly DbSet<SalaryBonus> salaryBonuss;

        public SalaryBonusRepos(EmployeeDbContext context, DbSet<SalaryBonus> salaryBonuss)
        {
            this.context = context;
            this.salaryBonuss = salaryBonuss;
        }

        public async Task<bool> CreateAsync(SalaryBonus salaryBonus)
        {
            try
            {
                await context.AddAsync(salaryBonus);
                await context.SaveChangesAsync();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(SalaryBonus salaryBonus)
        {
            try
            {
                context.Remove(salaryBonus);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<SalaryBonus> GetAll()
        {
            return salaryBonuss.ToList();
        }

        

        public bool Update(SalaryBonus salaryBonus)
        {
            try
            {
                context.Update(salaryBonus);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }
}
