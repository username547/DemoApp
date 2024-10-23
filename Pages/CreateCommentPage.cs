using DemoApp.DTOs;
using DemoApp.Models;
using DemoApp.Repository;
using DemoApp.Service;

namespace DemoApp.Pages
{
    public partial class CreateCommentPage : UserControl
    {
        private readonly ICommentRepo _commentRepo;
        private readonly IAuthService _authService;

        public event EventHandler CreateButtonClicked;
        public event EventHandler BackButtonClicked;
        public CreateCommentDto createCommentDto;

        public CreateCommentPage(ICommentRepo commentRepo, IAuthService authService)
        {
            InitializeComponent();

            _commentRepo = commentRepo;
            _authService = authService;

            createCommentDto = new CreateCommentDto();
        }

        private void ClearForm()
        {
            CommentInput.Clear();
        }

        private void CreateCommentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CommentInput.Text)) return;
            if (_authService.CurrentUser.Id != createCommentDto.EmployeeId) return; 

            var newComment = new CommentModel
            {
                Text = CommentInput.Text,
                CreatedAt = DateTime.UtcNow,
                ServiceId = createCommentDto.ServiceId,
                EmployeeId = createCommentDto.EmployeeId,
            };
            _commentRepo.Create(newComment);

            ClearForm();

            CreateButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
