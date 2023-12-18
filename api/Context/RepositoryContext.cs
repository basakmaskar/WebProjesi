using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }


    }
}
