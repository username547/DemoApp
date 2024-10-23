using DemoApp.DTOs;
using DemoApp.Service;

namespace DemoApp.Pages
{
    public partial class LoginPage : UserControl
    {
        private readonly IAuthService _authService;

        public event EventHandler LoginButtonClicked;

        public LoginPage(IAuthService authService)
        {
            InitializeComponent();

            _authService = authService;
        }

        private void ClearForm()
        {
            loginInput.Clear();
            passwordInput.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginDto dto = new LoginDto
            {
                Login = loginInput.Text,
                Password = passwordInput.Text,
            };
            bool result = _authService.Login(dto);
            if (result) ClearForm();
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
