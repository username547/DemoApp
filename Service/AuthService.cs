using DemoApp.DTOs;
using DemoApp.Models;
using DemoApp.Repository;

namespace DemoApp.Service
{
    public interface IAuthService
    {
        EmployeeModel? CurrentUser { get; }
        bool Login(LoginDto dto);
        void Logout();
    }

    public class AuthService : IAuthService
    {
        private readonly IEmployeeRepo _employeeRepo;

        private EmployeeModel? _currentUser;

        public AuthService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public bool Login(LoginDto dto)
        {
            var user = _employeeRepo.GetByLogin(dto.Login);
            if (user == null) return false;
            if (dto.Password != user.Password) return false;
            CurrentUser = user;
            return true;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public EmployeeModel? CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }
    }
}
