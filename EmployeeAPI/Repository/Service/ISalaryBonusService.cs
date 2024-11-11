using AppData.Data;

namespace AppAPI.Repository.Service
{
    public interface ISalaryBonusService
    {
        Task<SalaryBonus> CreateSalaryBonusAsync(SalaryBonus salaryBonus);
    }
}
