using HireYourGuide.Data.Infrastructure;
using HireYourGuide.Model.Models;

namespace HireYourGuide.Data.Repositories
{
    public interface IproductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}