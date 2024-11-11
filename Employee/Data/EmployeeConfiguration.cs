using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Data
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            builder.HasOne(d => d.Department).WithMany(e => e.Employees).HasForeignKey(d => d.DepartmentId);
            builder.HasOne(p => p.Position).WithMany(e =>e.Employees).HasForeignKey(d =>d.PositionId);
            builder.HasMany(s => s.SalaryBonus).WithOne(e => e.Employee).HasForeignKey(c => c.SalaryBonusId);
            builder.HasMany(a => a.Attendances).WithOne(e => e.Employee).HasForeignKey(v => v.AttendanceId);
        }
    }
}
