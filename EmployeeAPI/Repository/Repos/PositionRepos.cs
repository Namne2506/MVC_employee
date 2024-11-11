using AppData.Data;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Repository.Repos
{
    public class PositionRepos : IPositionRepos
    {
        private readonly EmployeeDbContext context;
        private readonly DbSet<Position> positions;

        public PositionRepos(EmployeeDbContext context, DbSet<Position> positions)
        {
            this.context = context;
            this.positions = positions;
        }

        public bool Create(Position position)
        {
            try
            {
                context.Add(position);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Position position)
        {
            try
            {
                context.Remove(position);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Position> GetAll()
        {
            return positions.ToList();
        }

        public Task<Position> GetPositionByIdAsync(int positionId)
        {
            return context.Positions.FirstOrDefaultAsync(p => p.PositionId == positionId);
        }

        public bool Update(Position position)
        {
            try
            {
                context.Update(position);
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
