using DemoApp.Pages;
using DemoApp.Service;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        private readonly LoginPage _loginPage;
        private readonly ServicePage _servicesPage;
        private readonly IAuthService _authService;

        public MainForm(LoginPage loginPage, ServicePage servicesPage, IAuthService authService)
        {
            InitializeComponent();

            _loginPage = loginPage;
            _servicesPage = servicesPage;
            _authService = authService;

            _loginPage.LoginButtonClicked += Login_LoginButtonClicked;

            NavigateToLoginPage();
        }

        private void Login_LoginButtonClicked(object sender, EventArgs e)
        {
            if (_authService.CurrentUser != null)
            {
                LoginBtn.Visible = false;
                LogoutBtn.Visible = true;
                ServiceBtn.Visible = true;
                NavigateToServicePage();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void NavigateToLoginPage()
        {
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(_loginPage);
        }

        private void NavigateToServicePage()
        {
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(_servicesPage);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            NavigateToLoginPage();
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            NavigateToServicePage();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            LoginBtn.Visible = true;
            LogoutBtn.Visible = false;
            ServiceBtn.Visible = false;
            NavigateToLoginPage();
        }
    }
}
