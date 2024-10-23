using DemoApp.Data;
using DemoApp.DTOs;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IServiceRepo
    {
        List<ServiceModel> GetAll();
        ServiceModel? Get(int id);
        int GetStatusByServiceId(int id);
        ServiceModel Create(ServiceModel service);
        void Update(ServiceModel service);
        void Delete(int id);
    }

    public class ServiceRepo : IServiceRepo
    {
        protected readonly AppDbContext _context;

        public ServiceRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<ServiceModel> GetAll()
        {
            return _context.Services.ToList();
        }

        public ServiceModel? Get(int id)
        {
            return _context.Services.FirstOrDefault(x => x.Id == id);
        }

        public int GetStatusByServiceId(int id)
        {
            var result = from su in _context.StatusUpdates
                         join s in _context.Statuses on su.StatusId equals s.Id
                         where su.ServiceId == id
                         orderby su.UpdatedAt descending
                         select su.StatusId;
            return result.FirstOrDefault();
        }

        public ServiceModel Create(ServiceModel service)
        {
            var created = _context.Services.Add(service);
            _context.SaveChanges();
            return created.Entity;
        }

        public void Update(ServiceModel service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var service = _context.Services.FirstOrDefault(x => x.Id == id);
            if (service != null)
            {
                _context.Services.Remove(service);
                _context.SaveChanges();
            }
        }
    }
}
