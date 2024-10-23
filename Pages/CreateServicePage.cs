using DemoApp.Models;
using DemoApp.Repository;

namespace DemoApp.Pages
{
    public partial class CreateServicePage : UserControl
    {
        private readonly IServiceRepo _serviceRepo;
        private readonly IClientRepo _clientRepo;
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IDeviceRepo _deviceRepo;
        private readonly IStatusRepo _statusRepo;
        private readonly IStatusUpdateRepo _statusUpdateRepo;

        public event EventHandler CreateButtonClicked;
        public event EventHandler BackButtonClicked;

        public CreateServicePage(IServiceRepo serviceRepo, IClientRepo clientRepo, IEmployeeRepo employeeRepo,
            IDeviceRepo deviceRepo, IStatusRepo statusRepo, IStatusUpdateRepo statusUpdateRepo)
        {
            InitializeComponent();

            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
            _employeeRepo = employeeRepo;
            _deviceRepo = deviceRepo;
            _statusRepo = statusRepo;
            _statusUpdateRepo = statusUpdateRepo;

            LoadData();
        }

        public void LoadData()
        {
            var clients = _clientRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var devices = _deviceRepo.GetAll();

            ClientComboBox.DataSource = clients;
            ClientComboBox.DisplayMember = "Name";
            ClientComboBox.ValueMember = "Id";

            EmployeeComboBox.DataSource = employees;
            EmployeeComboBox.DisplayMember = "FullName";
            EmployeeComboBox.ValueMember = "Id";

            DeviceComboBox.DataSource = devices;
            DeviceComboBox.DisplayMember = "Name";
            DeviceComboBox.ValueMember = "Id";
        }

        private void ClearForm()
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string priority = (string)PriorityComboBox.SelectedItem!;
                string type = (string)TypeComboBox.SelectedItem!;
                string desc = DescTextBox.Text;
                string reason = ReasonTextBox.Text;
                int price = Convert.ToInt32(PriceTextBox.Text);
                int clientId = (int)ClientComboBox.SelectedValue!;
                int employeeId = (int)EmployeeComboBox.SelectedValue!;
                string deviceId = (string)DeviceComboBox.SelectedValue!;

                ServiceModel service = new ServiceModel
                {
                    Priority = priority,
                    Type = type,
                    Desc = desc,
                    Reason = reason,
                    Price = price,
                    CreatedAt = DateTime.UtcNow,
                    ClientId = clientId,
                    EmployeeId = employeeId,
                    DeviceId = deviceId
                };
                var createdService = _serviceRepo.Create(service);

                var status = _statusRepo.GetByName("Не выполнено");
                if (status == null) throw new("Статус не найден");

                StatusUpdateModel statusUpdate = new StatusUpdateModel
                {
                    ServiceId = createdService.Id,
                    StatusId = status.Id,
                    UpdatedAt = DateTime.UtcNow,
                };
                _statusUpdateRepo.Create(statusUpdate);

                ClearForm();

                CreateButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
