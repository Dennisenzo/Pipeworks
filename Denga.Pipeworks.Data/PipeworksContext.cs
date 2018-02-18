using Microsoft.EntityFrameworkCore;

namespace Denga.Pipeworks.Data
{
    public abstract class PipeworksContext : DbContext
    {
        protected PipeworksContext() :base()
        {
        }
    }
}
