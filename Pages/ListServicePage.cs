using DemoApp.Models;
using DemoApp.Repository;

namespace DemoApp.Pages
{
    public partial class ListServicePage : UserControl
    {
        private readonly IServiceRepo _serviceRepo;

        public ServiceModel? selectedService;

        public ListServicePage(IServiceRepo serviceRepo)
        {
            InitializeComponent();
            _serviceRepo = serviceRepo;
            LoadData();
        }

        public void LoadData()
        {
            var services = _serviceRepo.GetAll();
            ServiceDataGrid.DataSource = services;
            ServiceDataGrid.Columns["Client"].Visible = false;
            ServiceDataGrid.Columns["Employee"].Visible = false;
            ServiceDataGrid.Columns["Device"].Visible = false;
            ServiceDataGrid.Columns["StatusUpdates"].Visible = false;
            ServiceDataGrid.Columns["ServiceDetails"].Visible = false;
            ServiceDataGrid.Columns["Comments"].Visible = false;
        }

        private void ServiceDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ServiceDataGrid.SelectedRows.Count > 0)
                selectedService = (ServiceModel)ServiceDataGrid.SelectedRows[0].DataBoundItem;
        }
    }
}
