using HireYourGuide.Data.Infrastructure;
using HireYourGuide.Model.Models;

namespace HireYourGuide.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}