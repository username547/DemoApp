using DemoApp.Data;
using DemoApp.Models;

namespace DemoApp.Repository
{
    public interface ICommentRepo
    {
        CommentModel Create(CommentModel comment);
    }

    public class CommentRepo : ICommentRepo
    {
        protected readonly AppDbContext _context;

        public CommentRepo(AppDbContext context)
        {
            _context = context;
        }

        public CommentModel Create(CommentModel comment)
        {
            var created = _context.Comments.Add(comment);
            _context.SaveChanges();
            return created.Entity;
        }
    }
}
