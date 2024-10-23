using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IEmployeeRepo
    {
        List<EmployeeModel> GetAll();
        EmployeeModel? GetByLogin(string login);
    }

    public class EmployeeRepo : IEmployeeRepo
    {
        protected readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<EmployeeModel> GetAll()
        {
            return _context.Employees.ToList();
        }

        public EmployeeModel? GetByLogin(string login)
        {
            return _context.Employees.FirstOrDefault(x => x.Login == login);
        }
    }
}
