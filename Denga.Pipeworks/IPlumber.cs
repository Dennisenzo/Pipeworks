using Microsoft.Extensions.DependencyInjection;

namespace Denga.Pipeworks
{
    public interface IPlumber
    {
        IServiceCollection Services { get; }

        string ConnectionString { get; set; }
       
    }
}