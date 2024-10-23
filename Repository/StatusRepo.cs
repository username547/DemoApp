using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IStatusRepo
    {
        List<StatusModel> GetAll();
        StatusModel? GetByName(string name);
    }

    public class StatusRepo : IStatusRepo
    {
        protected readonly AppDbContext _context;

        public StatusRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<StatusModel> GetAll()
        {
            return _context.Statuses.ToList();
        }

        public StatusModel? GetByName(string name)
        {
            return _context.Statuses.FirstOrDefault(x => x.Name == name);
        }
    }
}
