using Denga.Pipeworks.Data;
using Microsoft.EntityFrameworkCore;

namespace Denga.Pipeworks.HttpCommunication
{
    public class DataContext : PipeworksContext<DataContext>
    {
        public DataContext( DbContextOptions<DataContext> settings) : base(settings)
        {
        }
    }
}