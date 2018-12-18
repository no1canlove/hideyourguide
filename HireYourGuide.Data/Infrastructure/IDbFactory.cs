using System;

namespace HireYourGuide.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HireYourGuideDbContext Init();
    }
}