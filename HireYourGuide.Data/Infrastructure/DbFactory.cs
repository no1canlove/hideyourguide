namespace HireYourGuide.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HireYourGuideDbContext dbContext;

        public HireYourGuideDbContext Init()
        {
            return dbContext ?? (dbContext = new HireYourGuideDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}