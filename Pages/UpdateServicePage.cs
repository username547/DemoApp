using DemoApp.Models;
using DemoApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoApp.Pages
{
    public partial class UpdateServicePage : UserControl
    {
        private readonly IServiceRepo _serviceRepo;
        private readonly IClientRepo _clientRepo;
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IDeviceRepo _deviceRepo;
        private readonly IStatusRepo _statusRepo;
        private readonly IStatusUpdateRepo _statusUpdateRepo;

        public event EventHandler UpdateButtonClicked;
        public event EventHandler BackButtonClicked;

        public ServiceModel selectedService;

        public UpdateServicePage(IServiceRepo serviceRepo, IClientRepo clientRepo, IEmployeeRepo employeeRepo,
            IDeviceRepo deviceRepo, IStatusRepo statusRepo, IStatusUpdateRepo statusUpdateRepo)
        {
            _serviceRepo = serviceRepo;
            _clientRepo = clientRepo;
            _employeeRepo = employeeRepo;
            _deviceRepo = deviceRepo;
            _statusRepo = statusRepo;
            _statusUpdateRepo = statusUpdateRepo;

            InitializeComponent();
        }

        public void LoadData()
        {
            var clients = _clientRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var devices = _deviceRepo.GetAll();
            var statuses = _statusRepo.GetAll();

            ClientComboBox.DataSource = clients;
            ClientComboBox.DisplayMember = "Name";
            ClientComboBox.ValueMember = "Id";
            
            EmployeeComboBox.DataSource = employees;
            EmployeeComboBox.DisplayMember = "FullName";
            EmployeeComboBox.ValueMember = "Id";
            
            DeviceComboBox.DataSource = devices;
            DeviceComboBox.DisplayMember = "Name";
            DeviceComboBox.ValueMember = "Id";

            StatusComboBox.DataSource = statuses;
            StatusComboBox.DisplayMember = "Name";
            StatusComboBox.ValueMember = "Id";

            if (selectedService != null) LoadSelectedServiceData();
        }

        public void LoadSelectedServiceData()
        {
            ClientComboBox.SelectedValue = selectedService.ClientId;
            EmployeeComboBox.SelectedValue = selectedService.EmployeeId;
            DeviceComboBox.SelectedValue = selectedService.DeviceId;
            StatusComboBox.SelectedValue = _serviceRepo.GetStatusByServiceId(selectedService.Id);
            PriorityComboBox.SelectedItem = selectedService.Priority;
            TypeComboBox.SelectedItem = selectedService.Type;
            PriceTextBox.Text = Convert.ToString(selectedService.Price);
            DescTextBox.Text = Convert.ToString(selectedService.Desc);
            ReasonTextBox.Text = Convert.ToString(selectedService.Reason);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
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
                int statusId = (int)StatusComboBox.SelectedValue!;

                var service = _serviceRepo.Get(selectedService.Id);
                if (service == null) throw new Exception("Сервис не найден");

                service.Priority = priority;
                service.Type = type;
                service.Desc = desc;
                service.Reason = reason;
                service.Price = price;
                service.ClientId = clientId;
                service.EmployeeId = employeeId;
                service.DeviceId = deviceId;
                _serviceRepo.Update(service);

                StatusUpdateModel statusUpdate = new StatusUpdateModel
                {
                    ServiceId = selectedService.Id,
                    StatusId = statusId,
                    UpdatedAt = DateTime.UtcNow,
                };
                _statusUpdateRepo.Create(statusUpdate);

                ClearForm();

                UpdateButtonClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
