using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IStatusUpdateRepo
    {
        List<StatusUpdateModel> GetAll();
        void Create(StatusUpdateModel status);
    }

    public class StatusUpdateRepo : IStatusUpdateRepo
    {
        protected readonly AppDbContext _context;

        public StatusUpdateRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<StatusUpdateModel> GetAll()
        {
            return _context.StatusUpdates.ToList();
        }

        public void Create(StatusUpdateModel status)
        {
            _context.StatusUpdates.Add(status);
            _context.SaveChanges();
        }
    }
}
