using AppData.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppAPI.Repository.Repos
{
    public class AttendanceRepos : IAttendanceRepos
    {
        private readonly EmployeeDbContext context;
        private readonly DbSet<AttendanceRepos> attendances;

        public AttendanceRepos(EmployeeDbContext context, DbSet<AttendanceRepos> attendances)
        {
            this.context = context;
            this.attendances = attendances;
        }

        public bool Create(AttendanceRepos attendance)
        {
            try
            {
                context.Add(attendance);
                context.SaveChanges();
                return true;
            }catch (Exception )
            {
                return false;
            }
        }

        public bool Delete(AttendanceRepos attendance)
        {
            try
            {
                context.Remove(attendance);
                context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public IEnumerable<AttendanceRepos> GetAll()
        {
            return attendances.ToList();
        }

        public bool Update(AttendanceRepos attendance)
        {
            try
            {
                context.Update(attendance);
                context.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
