using DemoApp.Repository;
using DemoApp.Service;

namespace DemoApp.Pages
{
    public partial class ServicePage : UserControl
    {
        private readonly ListServicePage _listServicePage;
        private readonly CreateServicePage _createServicePage;
        private readonly UpdateServicePage _updateServicePage;
        private readonly CreateCommentPage _createCommentPage;
        private readonly IAuthService _authService;
        private readonly IServiceRepo _serviceRepo;

        public ServicePage(ListServicePage listServicePage, CreateServicePage createServicePage,
            UpdateServicePage updateServicePage, CreateCommentPage createCommentPage,
            IAuthService authService, IServiceRepo serviceRepo)
        {
            InitializeComponent();

            _listServicePage = listServicePage;
            _createServicePage = createServicePage;
            _updateServicePage = updateServicePage;
            _createCommentPage = createCommentPage;

            _authService = authService;
            _serviceRepo = serviceRepo;

            _createServicePage.CreateButtonClicked += CreateService_CreateOrBackBtnClicked;
            _createServicePage.BackButtonClicked += CreateService_CreateOrBackBtnClicked;
            _updateServicePage.UpdateButtonClicked += UpdateService_UpdateOrBackBtnClicked;
            _updateServicePage.BackButtonClicked += UpdateService_UpdateOrBackBtnClicked;
            _createCommentPage.CreateButtonClicked += CreateComment_CreateOrBackBtnClicked;
            _createCommentPage.BackButtonClicked += CreateComment_CreateOrBackBtnClicked;

            NavigateToListServicePage();
        }

        // Navigation

        private void NavigateToListServicePage()
        {
            serviceContentPanel.Controls.Clear();
            serviceContentPanel.Controls.Add(_listServicePage);
        }

        private void NavigateToCreateServicePage()
        {
            serviceContentPanel.Controls.Clear();
            serviceContentPanel.Controls.Add(_createServicePage);
        }

        private void NavigateToUpdateServicePage()
        {
            serviceContentPanel.Controls.Clear();
            serviceContentPanel.Controls.Add(_updateServicePage);
           
        }

        private void NavigateToCreateCommentPage()
        {
            serviceContentPanel.Controls.Clear();
            serviceContentPanel.Controls.Add(_createCommentPage);
        }

        // Create / Update / Back Buttons

        private void CreateService_CreateOrBackBtnClicked(object sender, EventArgs e)
        {
            _listServicePage.LoadData();
            NavigateToListServicePage();
        }

        private void UpdateService_UpdateOrBackBtnClicked(object sender, EventArgs e)
        {
            _listServicePage.LoadData();
            NavigateToListServicePage();
        }

        private void CreateComment_CreateOrBackBtnClicked(object sender, EventArgs e)
        {
            _listServicePage.LoadData();
            NavigateToListServicePage();
        }

        // Control Panel

        private void CreateServiceBtn_Click(object sender, EventArgs e)
        {
            NavigateToCreateServicePage();
        }

        private void UpdateServiceBtn_Click(object sender, EventArgs e)
        {
            if (_listServicePage.selectedService != null)
            {
                _updateServicePage.selectedService = _listServicePage.selectedService;
                _updateServicePage.LoadData();
                NavigateToUpdateServicePage();
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования");
            }
        }

        private void DeleteServiceBtn_Click(object sender, EventArgs e)
        {
            if (_listServicePage.selectedService != null)
            {
                _serviceRepo.Delete(_listServicePage.selectedService.Id);
                _listServicePage.LoadData();
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления");
            }
        }

        private void CreateCommentBtn_Click(object sender, EventArgs e)
        {
            var selectedService = _listServicePage.selectedService;
            var currentEmployee = _authService.CurrentUser;

            if (selectedService != null && currentEmployee.Id == selectedService.EmployeeId)
            {
                _createCommentPage.createCommentDto.ServiceId = selectedService.Id;
                _createCommentPage.createCommentDto.EmployeeId = currentEmployee.Id;
                NavigateToCreateCommentPage();
            }
            else
            {
                MessageBox.Show("Вы не выбрали заявку или не являетесь ее исполнителем");
            }
        }
    }
}
