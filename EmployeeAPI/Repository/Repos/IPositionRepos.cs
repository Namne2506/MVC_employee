using AppData.Data;

namespace AppAPI.Repository.Repos
{
    public interface IPositionRepos
    {
        public IEnumerable<Position> GetAll();

        Task<Position> GetPositionByIdAsync(int positionId);
        public bool Create(Position position);
        public bool Update(Position position);
        public bool Delete(Position position);
    }
}
