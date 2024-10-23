using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface IDeviceRepo
    {
        List<DeviceModel> GetAll();
    }

    public class DeviceRepo : IDeviceRepo
    {
        protected readonly AppDbContext _context;

        public DeviceRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<DeviceModel> GetAll()
        {
            return _context.Devices.ToList();
        }
    }
}
