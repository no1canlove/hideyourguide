namespace HireYourGuide.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}