using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IClientRepo
    {
        List<ClientModel> GetAll();
    }

    public class ClientRepo : IClientRepo
    {
        protected readonly AppDbContext _context;

        public ClientRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<ClientModel> GetAll()
        {
            return _context.Clients.ToList();
        }
    }
}
