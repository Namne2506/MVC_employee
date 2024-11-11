using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public class SalaryBonusConfiguration : IEntityTypeConfiguration<SalaryBonus>
    {
        public void Configure(EntityTypeBuilder<SalaryBonus> builder)
        {
            builder.HasKey(s => s.SalaryBonusId);
            builder.HasOne(e => e.Employee).WithMany(s => s.SalaryBonus).HasForeignKey(e => e.EmployeeId);
        }
    }
}
