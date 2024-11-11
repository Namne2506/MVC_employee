using AppData.Data;
namespace AppAPI.Repository.Repos
{
    public interface IAttendanceRepos
    {
        public IEnumerable<AttendanceRepos> GetAll();
        public bool Create(AttendanceRepos attendance);
        public bool Update(AttendanceRepos attendance);
        public bool Delete(AttendanceRepos attendance);
    }
}
